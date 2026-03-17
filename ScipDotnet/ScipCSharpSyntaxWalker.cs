using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Scip;
using CSharpSyntaxKind = Microsoft.CodeAnalysis.CSharp.SyntaxKind;

namespace ScipDotnet;

/// <summary>
/// Walks a single C# syntax tree and produces a SCIP <code>Document</code>.
/// Emits occurrences with appropriate SymbolRole flags including Definition,
/// Import, ReadAccess, WriteAccess, and ForwardDefinition.
/// </summary>
public class ScipCSharpSyntaxWalker : CSharpSyntaxWalker
{
    private readonly SemanticModel _semanticModel;
    private readonly ScipDocumentIndexer _scipDocumentIndexer;

    public ScipCSharpSyntaxWalker(ScipDocumentIndexer scipSymbolFormatter, SemanticModel semanticModel, SyntaxWalkerDepth depth = SyntaxWalkerDepth.Node) : base(depth)
    {
        _scipDocumentIndexer = scipSymbolFormatter;
        _semanticModel = semanticModel;
    }

    /// <summary>
    /// Determines whether a reference occurrence is a write access by checking
    /// if the identifier is on the left-hand side of an assignment expression.
    /// </summary>
    /// <param name="node">The syntax node for the identifier reference.</param>
    /// <returns>SymbolRole.WriteAccess if write, SymbolRole.ReadAccess otherwise.</returns>
    private static int GetAccessRole(SyntaxNode node)
    {
        var parent = node.Parent;

        // Direct assignment: x = ...
        if (parent is AssignmentExpressionSyntax assignment && assignment.Left == node)
            return (int)SymbolRole.WriteAccess;

        // Increment/decrement: x++, --x
        if (parent is PostfixUnaryExpressionSyntax or PrefixUnaryExpressionSyntax)
        {
            var kind = parent.Kind();
            if (kind is CSharpSyntaxKind.PostIncrementExpression or CSharpSyntaxKind.PostDecrementExpression
                or CSharpSyntaxKind.PreIncrementExpression or CSharpSyntaxKind.PreDecrementExpression)
                return (int)SymbolRole.WriteAccess;
        }

        // ref/out argument: Method(out x), Method(ref x)
        if (parent is ArgumentSyntax { RefOrOutKeyword.RawKind: not 0 })
            return (int)SymbolRole.WriteAccess;

        return (int)SymbolRole.ReadAccess;
    }

    /// <summary>
    /// Computes the ForwardDefinition flag for definitions that lack a body,
    /// such as abstract, extern, or partial method declarations.
    /// </summary>
    /// <param name="symbol">The Roslyn symbol being defined.</param>
    /// <returns>SymbolRole.ForwardDefinition flag or 0.</returns>
    private static int GetForwardDefinitionRole(ISymbol symbol)
    {
        return symbol switch
        {
            IMethodSymbol { IsAbstract: true } => (int)SymbolRole.ForwardDefinition,
            IMethodSymbol { IsExtern: true } => (int)SymbolRole.ForwardDefinition,
            IMethodSymbol { IsPartialDefinition: true } => (int)SymbolRole.ForwardDefinition,
            IPropertySymbol { IsAbstract: true } => (int)SymbolRole.ForwardDefinition,
            IEventSymbol { IsAbstract: true } => (int)SymbolRole.ForwardDefinition,
            _ => 0
        };
    }

    /// <summary>
    /// Emits a definition occurrence with appropriate role flags.
    /// </summary>
    private void EmitDefinition(ISymbol? symbol, Location location)
    {
        if (symbol == null) return;
        var roles = (int)SymbolRole.Definition | GetForwardDefinitionRole(symbol);
        _scipDocumentIndexer.VisitOccurrence(symbol, location, roles);
    }

    public override void VisitIdentifierName(IdentifierNameSyntax node)
    {
        if (!node.IsVar)
        {
            var symbol = _semanticModel.GetSymbolInfo(node).Symbol;
            var roles = GetAccessRole(node);
            _scipDocumentIndexer.VisitOccurrence(symbol, node.GetLocation(), roles);
        }

        base.VisitIdentifierName(node);
    }

    public override void VisitUsingDirective(UsingDirectiveSyntax node)
    {
        if (node.Name != null)
        {
            var symbol = _semanticModel.GetSymbolInfo(node.Name).Symbol;
            _scipDocumentIndexer.VisitOccurrence(symbol, node.Name.GetLocation(), (int)SymbolRole.Import);
        }

        base.VisitUsingDirective(node);
    }

    public override void VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitClassDeclaration(node);
    }

    public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitRecordDeclaration(node);
    }

    public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitEnumDeclaration(node);
    }

    public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitCatchDeclaration(node);
    }

    public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitConstructorDeclaration(node);
    }

    public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitDelegateDeclaration(node);
    }

    public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitDestructorDeclaration(node);
    }

    public override void VisitEventDeclaration(EventDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitEventDeclaration(node);
    }

    public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitInterfaceDeclaration(node);
    }

    public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitPropertyDeclaration(node);
    }

    public override void VisitStructDeclaration(StructDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitStructDeclaration(node);
    }

    public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitVariableDeclarator(node);
    }

    public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitEnumMemberDeclaration(node);
    }

    public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitMethodDeclaration(node);
    }

    public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitLocalFunctionStatement(node);
    }

    public override void VisitParameter(ParameterSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitParameter(node);
    }

    public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitSingleVariableDesignation(node);
    }

    public override void VisitTypeParameter(TypeParameterSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitTypeParameter(node);
    }

    public override void VisitForEachStatement(ForEachStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitForEachStatement(node);
    }

    public override void VisitFromClause(FromClauseSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitFromClause(node);
    }

    public override void VisitJoinClause(JoinClauseSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitJoinClause(node);
    }

    public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitJoinIntoClause(node);
    }

    public override void VisitLetClause(LetClauseSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitLetClause(node);
    }

    public override void VisitQueryContinuation(QueryContinuationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation());
        base.VisitQueryContinuation(node);
    }
}