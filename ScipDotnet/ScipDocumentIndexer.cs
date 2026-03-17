using System.Collections.Concurrent;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Scip;
using Document = Scip.Document;

namespace ScipDotnet;

/// <summary>
/// Creates SCIP <code>Document</code> based on provided symbols.
/// </summary>
public class ScipDocumentIndexer
{
    private readonly Document _doc;
    private readonly IndexCommandOptions _options;
    private int _localCounter;
    private readonly Dictionary<ISymbol, ScipSymbol> _globals;
    private readonly Dictionary<ISymbol, ScipSymbol> _locals = new(SymbolEqualityComparer.Default);
    private readonly string _markdownCodeFenceLanguage;
    private readonly Compilation? _compilation;
    private readonly ConcurrentDictionary<string, SymbolInformation>? _externalSymbols;

    // Custom formatting options to render symbol documentation. Feel free to tweak these parameters.
    // The options were derived by multiple rounds of experimentation with the goal of striking a
    // balance between showing detailed/accurate information without using too verbose syntax.
    private readonly SymbolDisplayFormat _format = new(
        globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining,
        typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameOnly,
        genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters |
                         SymbolDisplayGenericsOptions.IncludeVariance |
                         SymbolDisplayGenericsOptions.IncludeTypeConstraints,
        memberOptions: SymbolDisplayMemberOptions.IncludeAccessibility |
                       SymbolDisplayMemberOptions.IncludeModifiers |
                       SymbolDisplayMemberOptions.IncludeParameters |
                       SymbolDisplayMemberOptions.IncludeRef |
                       SymbolDisplayMemberOptions.IncludeType |
                       SymbolDisplayMemberOptions.IncludeConstantValue |
                       SymbolDisplayMemberOptions.IncludeContainingType |
                       SymbolDisplayMemberOptions.IncludeExplicitInterface,
        delegateStyle: SymbolDisplayDelegateStyle.NameAndSignature,
        extensionMethodStyle: SymbolDisplayExtensionMethodStyle.InstanceMethod,
        parameterOptions: SymbolDisplayParameterOptions.IncludeType |
                          SymbolDisplayParameterOptions.IncludeName |
                          SymbolDisplayParameterOptions.IncludeDefaultValue |
                          SymbolDisplayParameterOptions.IncludeExtensionThis |
                          SymbolDisplayParameterOptions.IncludeOptionalBrackets |
                          SymbolDisplayParameterOptions.IncludeParamsRefOut,
        propertyStyle: SymbolDisplayPropertyStyle.ShowReadWriteDescriptor,
        localOptions: SymbolDisplayLocalOptions.IncludeType |
                      SymbolDisplayLocalOptions.IncludeRef |
                      SymbolDisplayLocalOptions.IncludeConstantValue,
        kindOptions: SymbolDisplayKindOptions.IncludeTypeKeyword |
                     SymbolDisplayKindOptions.IncludeMemberKeyword |
                     SymbolDisplayKindOptions.IncludeNamespaceKeyword,
        miscellaneousOptions: SymbolDisplayMiscellaneousOptions.AllowDefaultLiteral |
                              SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                              SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays |
                              SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier |
                              SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers
    );

    /// <summary>
    /// Creates a new ScipDocumentIndexer for a single document.
    /// </summary>
    /// <param name="doc">The SCIP Document to populate with occurrences and symbols.</param>
    /// <param name="options">Indexing options including the EmitExternalSymbols flag.</param>
    /// <param name="globals">Shared global symbol registry for cross-document deduplication.</param>
    /// <param name="compilation">The Roslyn Compilation for the current project, used to compare assemblies.</param>
    /// <param name="externalSymbols">Shared dictionary collecting SymbolInformation for external assembly symbols.</param>
    public ScipDocumentIndexer(
        Document doc,
        IndexCommandOptions options,
        Dictionary<ISymbol, ScipSymbol> globals,
        Compilation? compilation = null,
        ConcurrentDictionary<string, SymbolInformation>? externalSymbols = null)
    {
        _doc = doc;
        _options = options;
        _globals = globals;
        _compilation = compilation;
        _externalSymbols = externalSymbols;
        _markdownCodeFenceLanguage = _doc.Language == "C#" ? "cs" : "vb";
    }

    private ScipSymbol CreateScipSymbol(ISymbol? sym)
    {
        if (sym == null)
        {
            return ScipSymbol.Empty;
        }

        var fromCache = _globals.GetValueOrDefault(sym, ScipSymbol.Empty);
        if (fromCache != ScipSymbol.Empty)
        {
            return fromCache;
        }

        if (IsLocalSymbol(sym))
        {
            return CreateLocalScipSymbol(sym);
        }

        var owner = sym.Kind == SymbolKind.Namespace
            ? CreateScipPackageSymbol(sym)
            : CreateScipSymbol(sym.ContainingSymbol);

        if (owner.IsLocal())
        {
            return CreateLocalScipSymbol(sym);
        }

        var result = ScipSymbol.Global(owner, new SymbolDescriptor
        {
            Name = sym.Name,
            Suffix = SymbolSuffix(sym),
            Disambiguator = MethodDisambiguator(sym)
        });
        _globals.TryAdd(sym, result);
        return result;
    }

    private ScipSymbol CreateLocalScipSymbol(ISymbol sym)
    {
        var local = _locals.GetValueOrDefault(sym, ScipSymbol.Empty);
        if (local != ScipSymbol.Empty)
        {
            return local;
        }

        var localResult = ScipSymbol.Local(_localCounter++);
        _locals.TryAdd(sym, localResult);
        return localResult;
    }

    private ScipSymbol CreateScipPackageSymbol(ISymbol sym)
    {
        if (sym.ContainingAssembly == null)
        {
            return ScipSymbol.IndexLocalPackage;
        }

        if (!_options.AllowGlobalSymbolDefinitions && sym.Locations.Any(location => location.IsInSource))
        {
            // Emit index-local symbols to avoid exporting public symbols into the global scope (all repos in the world).
            // We have no guarantee that a random csproj file from any random repository is publishing to NuGet.
            // Use the command-line flag --allow-global-symbol-definitions to disable this behavior.
            return ScipSymbol.IndexLocalPackage;
        }

        return ScipSymbol.Package(
            sym.ContainingAssembly.Identity.Name,
            sym.ContainingAssembly.Identity.Version.ToString());
    }

    private SymbolDescriptor.Types.Suffix SymbolSuffix(ISymbol sym)
    {
        switch (sym.Kind)
        {
            case SymbolKind.Namespace:
                return SymbolDescriptor.Types.Suffix.Package;
            case SymbolKind.NamedType:
            case SymbolKind.FunctionPointerType:
            case SymbolKind.ErrorType:
            case SymbolKind.PointerType:
            case SymbolKind.ArrayType:
            case SymbolKind.DynamicType:
            case SymbolKind.Alias:
            case SymbolKind.Event:
                return SymbolDescriptor.Types.Suffix.Type;
            case SymbolKind.Property:
            case SymbolKind.Field:
            case SymbolKind.Assembly:
            case SymbolKind.Label:
            case SymbolKind.NetModule:
            case SymbolKind.RangeVariable:
            case SymbolKind.Preprocessing:
            case SymbolKind.Discard:
                return SymbolDescriptor.Types.Suffix.Term;
            case SymbolKind.Method:
                return SymbolDescriptor.Types.Suffix.Method;
            case SymbolKind.Parameter:
                return SymbolDescriptor.Types.Suffix.Parameter;
            case SymbolKind.TypeParameter:
                return SymbolDescriptor.Types.Suffix.TypeParameter;
            case SymbolKind.Local:
                return SymbolDescriptor.Types.Suffix.Local;
            default:
                _options.Logger.LogWarning("unknown symbol kind {SymKind}", sym.Kind);
                return SymbolDescriptor.Types.Suffix.Meta;
        }
    }

    private static string MethodDisambiguator(ISymbol sym)
    {
        if (sym is not IMethodSymbol)
        {
            return "";
        }

        var overloadCount = 0;
        foreach (var member in sym.ContainingType.GetMembers())
        {
            if (member.Equals(sym, SymbolEqualityComparer.Default))
            {
                return overloadCount == 0 ? "" : $"+{overloadCount}";
            }

            if (member.Name.Equals(sym.Name))
            {
                overloadCount++;
            }
        }

        return "";
    }

    private readonly string[] _isIgnoredRelationshipSymbol =
    {
        " System/Object#",
        " System/Enum#",
        " System/ValueType#",
    };

    // Returns true if this symbol should not be emitted as a SymbolInformation relationship symbol.
    // The reason we ignore these symbols is because they appear automatically for a large number of
    // symbols putting pressure on our backend to index the inverted index. It's not particularly useful anyways
    // to query all the implementations of something like System/Object#.
    private bool IsIgnoredRelationshipSymbol(string symbol) =>
        _isIgnoredRelationshipSymbol.Any(symbol.EndsWith);

    /// <summary>
    /// Records a SCIP occurrence for the given Roslyn symbol at the specified location.
    /// The symbolRoles parameter is a bitset of SymbolRole flags (Definition, Import,
    /// ReadAccess, WriteAccess, ForwardDefinition, etc.).
    /// </summary>
    public void VisitOccurrence(ISymbol? symbol, Location location, int symbolRoles)
    {
        if (symbol == null)
        {
            return;
        }

        var scipSymbol = CreateScipSymbol(symbol).Value;
        var occurrence = new Occurrence
        {
            Symbol = scipSymbol,
            SymbolRoles = symbolRoles
        };
        _doc.Occurrences.Add(occurrence);
        foreach (var range in LocationToRange(location))
        {
            occurrence.Range.Add(range);
        }

        var isDefinition = (symbolRoles & (int)SymbolRole.Definition) != 0;

        // Collect external symbol information for cross-assembly references.
        // GetOrAdd ensures each external symbol is processed once; GetDocumentationCommentXml()
        // (the expensive XML doc I/O) only fires on the first encounter.
        if (!isDefinition && _options.EmitExternalSymbols && _externalSymbols != null
            && _compilation != null && symbol.ContainingAssembly != null
            && !SymbolEqualityComparer.Default.Equals(symbol.ContainingAssembly, _compilation.Assembly))
        {
            _externalSymbols.GetOrAdd(scipSymbol, _ =>
            {
                var extInfo = new SymbolInformation
                {
                    Symbol = scipSymbol,
                    DisplayName = symbol.Name,
                    Kind = MapSymbolKind(symbol)
                };
                var signature = symbol.ToDisplayString(_format);
                if (signature.Length > 0)
                {
                    extInfo.Documentation.Add($"```{_markdownCodeFenceLanguage}\n{signature}\n```");
                }
                var xmlDoc = symbol.GetDocumentationCommentXml();
                if (xmlDoc?.Length > 0)
                {
                    extInfo.Documentation.Add(xmlDoc);
                }
                return extInfo;
            });
        }

        if (!isDefinition) return;

        // Emit SymbolInformation for this definition occurrence.
        var info = new SymbolInformation
        {
            Symbol = scipSymbol,
            DisplayName = symbol.Name,
            Kind = MapSymbolKind(symbol)
        };
        _doc.Symbols.Add(info);

        var symbolSignature = symbol.ToDisplayString(_format);
        if (symbolSignature.Length > 0)
        {
            info.Documentation.Add($"```{_markdownCodeFenceLanguage}\n{symbolSignature}\n```");
        }

        var symbolDocumentation = symbol.GetDocumentationCommentXml();
        if (symbolDocumentation?.Length > 0)
        {
            info.Documentation.Add(symbolDocumentation);
        }

        switch (symbol)
        {
            case INamedTypeSymbol namedTypeSymbol:
                {
                    var baseType = namedTypeSymbol.BaseType;
                    while (baseType != null)
                    {
                        var baseTypeSymbol = CreateScipSymbol(baseType).Value;
                        if (IsIgnoredRelationshipSymbol(baseTypeSymbol))
                        {
                            break;
                        }

                        info.Relationships.Add(new Relationship
                        {
                            Symbol = baseTypeSymbol,
                            IsImplementation = true
                        });
                        baseType = baseType.BaseType;
                    }

                    foreach (var interfaceSymbol in namedTypeSymbol.AllInterfaces)
                    {
                        var interfaceSymbolSymbol = CreateScipSymbol(interfaceSymbol).Value;
                        if (IsIgnoredRelationshipSymbol(interfaceSymbolSymbol))
                        {
                            continue;
                        }

                        info.Relationships.Add(new Relationship
                        {
                            Symbol = interfaceSymbolSymbol,
                            IsImplementation = true
                        });
                    }

                    break;
                }
            case IMethodSymbol methodSymbol:
                {
                    var overriddenMethod = methodSymbol.OverriddenMethod;
                    while (overriddenMethod != null)
                    {
                        info.Relationships.Add(new Relationship
                        {
                            Symbol = CreateScipSymbol(overriddenMethod).Value,
                            IsImplementation = true,
                            IsReference = true
                        });
                        overriddenMethod = overriddenMethod.OverriddenMethod;
                    }

                    foreach (var interfaceMethod in ScipDocumentIndexer.InterfaceImplementations(methodSymbol))
                    {
                        info.Relationships.Add(new Relationship
                        {
                            Symbol = CreateScipSymbol(interfaceMethod).Value,
                            IsImplementation = true,
                            IsReference = true
                        });
                    }

                    break;
                }
        }

        // Emit is_type_definition relationship for symbols that have a declared type.
        // This enables "Go to type definition" in code intelligence consumers.
        EmitTypeDefinitionRelationship(info, symbol);
    }

    /// <summary>
    /// Emits a Relationship with is_type_definition=true for symbols that have a
    /// declared type (fields, properties, parameters, local variables, events).
    /// This enables "Go to type definition" navigation in code intelligence consumers.
    /// </summary>
    /// <param name="info">The SymbolInformation to add the relationship to.</param>
    /// <param name="symbol">The Roslyn symbol whose declared type is resolved.</param>
    private void EmitTypeDefinitionRelationship(SymbolInformation info, ISymbol symbol)
    {
        ITypeSymbol? typeSymbol = symbol switch
        {
            IFieldSymbol field => field.Type,
            IPropertySymbol property => property.Type,
            IParameterSymbol parameter => parameter.Type,
            ILocalSymbol local => local.Type,
            IEventSymbol eventSymbol => eventSymbol.Type,
            _ => null
        };

        if (typeSymbol == null) return;

        var typeScipSymbol = CreateScipSymbol(typeSymbol).Value;
        if (typeScipSymbol.Length == 0 || IsIgnoredRelationshipSymbol(typeScipSymbol)) return;

        info.Relationships.Add(new Relationship
        {
            Symbol = typeScipSymbol,
            IsTypeDefinition = true
        });
    }

    /// <summary>
    /// Maps a Roslyn ISymbol to the SCIP SymbolInformation.Kind enum.
    /// Uses Roslyn's ISymbol subtype and modifier properties (IsStatic, IsAbstract,
    /// IsConst, MethodKind, TypeKind) to select the most specific SCIP Kind value.
    /// Returns UnspecifiedKind for symbol types that don't have a direct mapping.
    /// </summary>
    /// <param name="symbol">The Roslyn symbol to classify.</param>
    /// <returns>The corresponding SCIP Kind enum value.</returns>
    private static SymbolInformation.Types.Kind MapSymbolKind(ISymbol symbol)
    {
        return symbol switch
        {
            INamedTypeSymbol { TypeKind: TypeKind.Class } => SymbolInformation.Types.Kind.Class,
            INamedTypeSymbol { TypeKind: TypeKind.Struct } => SymbolInformation.Types.Kind.Struct,
            INamedTypeSymbol { TypeKind: TypeKind.Interface } => SymbolInformation.Types.Kind.Interface,
            INamedTypeSymbol { TypeKind: TypeKind.Enum } => SymbolInformation.Types.Kind.Enum,
            INamedTypeSymbol { TypeKind: TypeKind.Delegate } => SymbolInformation.Types.Kind.Delegate,
            INamedTypeSymbol { TypeKind: TypeKind.Module } => SymbolInformation.Types.Kind.Module,

            IMethodSymbol { MethodKind: MethodKind.Constructor or MethodKind.StaticConstructor }
                => SymbolInformation.Types.Kind.Constructor,
            IMethodSymbol { MethodKind: MethodKind.Destructor }
                => SymbolInformation.Types.Kind.Method,
            IMethodSymbol { MethodKind: MethodKind.UserDefinedOperator or MethodKind.BuiltinOperator or MethodKind.Conversion }
                => SymbolInformation.Types.Kind.Operator,
            IMethodSymbol { IsAbstract: true } => SymbolInformation.Types.Kind.AbstractMethod,
            IMethodSymbol { IsStatic: true } => SymbolInformation.Types.Kind.StaticMethod,
            IMethodSymbol => SymbolInformation.Types.Kind.Method,

            IPropertySymbol { IsStatic: true } => SymbolInformation.Types.Kind.StaticProperty,
            IPropertySymbol => SymbolInformation.Types.Kind.Property,

            IFieldSymbol { IsConst: true } => SymbolInformation.Types.Kind.Constant,
            IFieldSymbol { IsStatic: true } => SymbolInformation.Types.Kind.StaticField,
            IFieldSymbol => SymbolInformation.Types.Kind.Field,

            IEventSymbol { IsStatic: true } => SymbolInformation.Types.Kind.StaticEvent,
            IEventSymbol => SymbolInformation.Types.Kind.Event,

            IParameterSymbol => SymbolInformation.Types.Kind.Parameter,
            ITypeParameterSymbol => SymbolInformation.Types.Kind.TypeParameter,
            ILocalSymbol => SymbolInformation.Types.Kind.Variable,
            INamespaceSymbol => SymbolInformation.Types.Kind.Namespace,

            _ => SymbolInformation.Types.Kind.UnspecifiedKind
        };
    }

    // Returns explicitly and implicitly implemented interface methods by the given symbol method.
    // The Roslyn API has a `ExplicitInterfaceImplementations` that does not return implicitly implemented
    // methods.
    private static IEnumerable<ISymbol> InterfaceImplementations(IMethodSymbol symbol)
    {
        foreach (var interfaceSymbol in symbol.ContainingType.AllInterfaces)
        {
            foreach (var interfaceMember in interfaceSymbol.GetMembers())
            {
                var implementation = symbol.ContainingType.FindImplementationForInterfaceMember(interfaceMember);
                if (implementation != null && symbol.Equals(implementation, SymbolEqualityComparer.Default))
                {
                    yield return interfaceMember;
                }
            }
        }
    }

    // Converts a Roslyn location into a SCIP range.
    private static IEnumerable<int> LocationToRange(Location location)
    {
        var span = location.GetMappedLineSpan();
        if (span.StartLinePosition.Line == span.EndLinePosition.Line)
        {
            return new[]
                {
                    span.StartLinePosition.Line,
                    span.StartLinePosition.Character,
                    span.EndLinePosition.Character
                };
        }

        return new[]
            {
                span.StartLinePosition.Line,
                span.StartLinePosition.Character,
                span.EndLinePosition.Line,
                span.EndLinePosition.Character
            };
    }

    private static bool IsLocalSymbol(ISymbol sym)
    {
        return sym.Kind == SymbolKind.Local ||
               sym.Kind == SymbolKind.RangeVariable ||
               sym.Kind == SymbolKind.TypeParameter ||
               sym is IMethodSymbol { MethodKind: MethodKind.LocalFunction } ||
               // Anonymous classes/methods have empty names and can not be accessed outside their file.
               // The "global namespace" (parent of all namespaces) also has an empty name and should not
               // be treated as a local variable.
               (sym.Name.Equals("") && sym.Kind != SymbolKind.Namespace);
    }
}
