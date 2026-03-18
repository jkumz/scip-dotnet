using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Scip;
using Document = Scip.Document;
using Kind = Scip.SymbolInformation.Types.Kind;

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

    // Index-wide accounting shared across every document, used to populate
    // Index.external_symbols. `_externalSymbols` maps a SCIP symbol string to the
    // SymbolInformation we will emit for a referenced external-package symbol.
    // `_definedSymbols` is the set of symbols that already have an in-source definition;
    // it lets us avoid duplicating a symbol in external_symbols (relevant when
    // --allow-global-symbol-definitions assigns a real package name to a source symbol).
    private readonly Dictionary<string, SymbolInformation> _externalSymbols;
    private readonly HashSet<string> _definedSymbols;
    private readonly string _markdownCodeFenceLanguage;

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

    public ScipDocumentIndexer(
        Document doc,
        IndexCommandOptions options,
        Dictionary<ISymbol, ScipSymbol> globals,
        Dictionary<string, SymbolInformation> externalSymbols,
        HashSet<string> definedSymbols)
    {
        _doc = doc;
        _options = options;
        _globals = globals;
        _externalSymbols = externalSymbols;
        _definedSymbols = definedSymbols;
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

    // SymbolInformation.Kind from the Roslyn symbol; anything not listed stays UnspecifiedKind.
    private static Kind ScipKind(ISymbol sym) => sym switch
    {
        INamedTypeSymbol { TypeKind: TypeKind.Class } => Kind.Class,
        INamedTypeSymbol { TypeKind: TypeKind.Interface } => Kind.Interface,
        INamedTypeSymbol { TypeKind: TypeKind.Struct } => Kind.Struct,
        INamedTypeSymbol { TypeKind: TypeKind.Enum } => Kind.Enum,
        INamedTypeSymbol { TypeKind: TypeKind.Delegate } => Kind.Delegate,
        INamedTypeSymbol { TypeKind: TypeKind.Module } => Kind.Module,
        IMethodSymbol { MethodKind: MethodKind.Constructor or MethodKind.StaticConstructor } => Kind.Constructor,
        IMethodSymbol { MethodKind: MethodKind.Ordinary, IsStatic: true } => Kind.StaticMethod,
        IMethodSymbol { MethodKind: MethodKind.Ordinary } => Kind.Method,
        IPropertySymbol { IsIndexer: false, IsStatic: true } => Kind.StaticProperty,
        IPropertySymbol { IsIndexer: false } => Kind.Property,
        IFieldSymbol { ContainingType.TypeKind: TypeKind.Enum } => Kind.EnumMember,
        IFieldSymbol { IsConst: true } => Kind.Constant,
        IFieldSymbol { IsStatic: true } => Kind.StaticField,
        IFieldSymbol => Kind.Field,
        IEventSymbol { IsStatic: true } => Kind.StaticEvent,
        IEventSymbol => Kind.Event,
        _ => Kind.UnspecifiedKind,
    };

    private static string MethodDisambiguator(ISymbol sym)
    {
        if (sym is not IMethodSymbol method)
        {
            return "";
        }

        // Type members are declarations, not constructed or reduced call-site symbols.
        // Compare declarations so different extension overloads keep distinct identities.
        method = (method.ReducedFrom ?? method).OriginalDefinition;
        var overloadCount = 0;
        foreach (var member in method.ContainingType.GetMembers())
        {
            if (member.Equals(method, SymbolEqualityComparer.Default))
            {
                return overloadCount == 0 ? "" : $"+{overloadCount}";
            }

            if (member.Name.Equals(method.Name))
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
    /// - For definitions: the entire definition AST node (excluding doc comments).
    /// - For references: the parent expression (e.g., a.b for a reference to b).
    /// </summary>
    public void VisitOccurrence(ISymbol? symbol, Location location, int symbolRoles, SyntaxNode? node = null)
    {
        if (symbol == null)
        {
            return;
        }

        var isDefinition = (symbolRoles & (int)SymbolRole.Definition) != 0;
        var scip = CreateScipSymbol(symbol);
        var scipSymbol = scip.Value;
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

        // Set enclosing_range
        if (node != null)
        {
            var enclosing = isDefinition
                ? FindEnclosingRangeForDefinition(node)
                : FindEnclosingRangeForReference(node);
            if (enclosing != null)
            {
                occurrence.EnclosingRange.AddRange(LineSpanToRange(enclosing.Value));
            }
        }

        if (!isDefinition)
        {
            // Supply dependency hover documentation even when the package is not indexed.
            if (scip.IsExternalPackageSymbol() && !_externalSymbols.ContainsKey(scipSymbol))
            {
                _externalSymbols[scipSymbol] = CreateExternalSymbolInformation(symbol, scipSymbol);
            }

            return;
        }

        // Emit SymbolInformation for this definition occurrence.
        _definedSymbols.Add(scipSymbol);
        var info = new SymbolInformation
        {
            Symbol = scipSymbol,
            DisplayName = symbol.Name,
            Kind = ScipKind(symbol)
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
                        var baseTypeScip = CreateScipSymbol(baseType);
                        if (IsIgnoredRelationshipSymbol(baseTypeScip.Value))
                        {
                            break;
                        }

                        info.Relationships.Add(new Relationship
                        {
                            Symbol = baseTypeScip.Value,
                            IsImplementation = true
                        });
                        CollectExternalRelationship(baseType, baseTypeScip);
                        baseType = baseType.BaseType;
                    }

                    foreach (var interfaceSymbol in namedTypeSymbol.AllInterfaces)
                    {
                        var interfaceScip = CreateScipSymbol(interfaceSymbol);
                        if (IsIgnoredRelationshipSymbol(interfaceScip.Value))
                        {
                            continue;
                        }

                        info.Relationships.Add(new Relationship
                        {
                            Symbol = interfaceScip.Value,
                            IsImplementation = true
                        });
                        CollectExternalRelationship(interfaceSymbol, interfaceScip);
                    }

                    break;
                }
            case IMethodSymbol methodSymbol:
                {
                    var overriddenMethod = methodSymbol.OverriddenMethod;
                    while (overriddenMethod != null)
                    {
                        var overriddenScip = CreateScipSymbol(overriddenMethod);
                        info.Relationships.Add(new Relationship
                        {
                            Symbol = overriddenScip.Value,
                            IsImplementation = true,
                            IsReference = true
                        });
                        CollectExternalRelationship(overriddenMethod, overriddenScip);
                        overriddenMethod = overriddenMethod.OverriddenMethod;
                    }

                    foreach (var interfaceMethod in ScipDocumentIndexer.InterfaceImplementations(methodSymbol))
                    {
                        var interfaceMethodScip = CreateScipSymbol(interfaceMethod);
                        info.Relationships.Add(new Relationship
                        {
                            Symbol = interfaceMethodScip.Value,
                            IsImplementation = true,
                            IsReference = true
                        });
                        CollectExternalRelationship(interfaceMethod, interfaceMethodScip);
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

        var typeScip = CreateScipSymbol(typeSymbol);
        var typeScipSymbol = typeScip.Value;
        if (typeScipSymbol.Length == 0 || IsIgnoredRelationshipSymbol(typeScipSymbol)) return;

        info.Relationships.Add(new Relationship
        {
            Symbol = typeScipSymbol,
            IsTypeDefinition = true
        });
        CollectExternalRelationship(typeSymbol, typeScip);
    }

    // Include documentation for relationship targets that have no source occurrence,
    // such as the implicitly implemented IEquatable<T> on a record.
    private void CollectExternalRelationship(ISymbol related, ScipSymbol scip)
    {
        if (scip.IsExternalPackageSymbol() && !_externalSymbols.ContainsKey(scip.Value))
        {
            _externalSymbols[scip.Value] = CreateExternalSymbolInformation(related, scip.Value);
        }
    }

    // Builds the SymbolInformation emitted into Index.external_symbols for a referenced
    // external-package symbol. We intentionally emit only the symbol and its hover
    // documentation: unlike in-source definitions we do NOT walk base types / interfaces,
    // because doing so would recurse across the entire BCL type graph and generate an
    // unbounded number of additional external symbols.
    private SymbolInformation CreateExternalSymbolInformation(ISymbol symbol, string scipSymbol)
    {
        // All constructions share a SCIP identity. Describe the declaration, not the
        // first use's type arguments or reduced extension-method receiver.
        if (symbol is IMethodSymbol { ReducedFrom: { } reducedMethod })
        {
            symbol = reducedMethod;
        }
        symbol = symbol.OriginalDefinition;

        var info = new SymbolInformation { Symbol = scipSymbol, DisplayName = symbol.Name };

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

        return info;
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
        return LineSpanToRange(span);
    }

    /// <summary>
    /// Converts a FileLinePositionSpan to SCIP's range format.
    /// Single-line ranges use [line, startChar, endChar]. Multi-line ranges
    /// use [startLine, startChar, endLine, endChar].
    /// </summary>
    private static int[] LineSpanToRange(FileLinePositionSpan span)
    {
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

    /// <summary>
    /// For definition occurrences, returns the span of the definition's own AST node.
    /// The walker passes the declaration node itself (e.g., MethodDeclarationSyntax,
    /// ClassDeclarationSyntax), so if the node is a declaration type, its own span
    /// is returned. Uses .Span (not .FullSpan), so XML doc comments are excluded.
    /// Falls back to walking Ancestors() for edge cases.
    /// </summary>
    /// <param name="node">The declaration syntax node.</param>
    /// <returns>The definition's line span, or null if none found.</returns>
    private static FileLinePositionSpan? FindEnclosingRangeForDefinition(SyntaxNode node)
    {
        if (node is Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
            or Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
            or Microsoft.CodeAnalysis.VisualBasic.Syntax.DeclarationStatementSyntax)
        {
            return node.SyntaxTree.GetLineSpan(node.Span);
        }

        // Fallback: walk ancestors for nodes that aren't declarations themselves
        // (e.g., parameter nodes, enum members).
        foreach (var ancestor in node.Ancestors())
        {
            if (ancestor is Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                or Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                or Microsoft.CodeAnalysis.VisualBasic.Syntax.DeclarationStatementSyntax)
            {
                return ancestor.SyntaxTree.GetLineSpan(ancestor.Span);
            }
        }
        return null;
    }

    /// <summary>
    /// For reference occurrences, walks up the expression chain to find the parent
    /// expression per the SCIP spec. Walks through MemberAccessExpression nodes
    /// and extends through InvocationExpression nodes that consume the access.
    ///
    /// Examples:
    ///   a.b         → returns span of a.b
    ///   a.b(41)     → returns span of a.b(41)
    ///   a.b(41).f(42).g(43) for f → returns span of a.b(41).f(42)
    ///   standalone x in 'return x' → returns span of x
    /// </summary>
    /// <param name="node">The identifier syntax node for the reference.</param>
    /// <returns>The parent expression's line span, or null if none found.</returns>
    private static FileLinePositionSpan? FindEnclosingRangeForReference(SyntaxNode node)
    {
        var current = node.Parent;
        if (current == null)
        {
            return node.SyntaxTree.GetLineSpan(node.Span);
        }

        // If the parent is not an expression, the identifier is the full expression.
        if (current is not Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            and not Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax)
        {
            return node.SyntaxTree.GetLineSpan(node.Span);
        }

        // Walk up the expression chain: extend through MemberAccess → Invocation patterns.
        while (current.Parent != null)
        {
            var parent = current.Parent;

            // If parent is an InvocationExpression and we are its invoked expression, extend.
            if ((parent is Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax csInvocation
                 && csInvocation.Expression == current)
                || (parent is Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax vbInvocation
                    && vbInvocation.Expression == current))
            {
                current = parent;
                continue;
            }

            // If parent is a MemberAccessExpression and we are its name, extend.
            if ((parent is Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax csMember
                 && csMember.Name == current)
                || (parent is Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax vbMember
                    && vbMember.Name == current))
            {
                current = parent;
                continue;
            }

            break;
        }

        return current.SyntaxTree.GetLineSpan(current.Span);
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
