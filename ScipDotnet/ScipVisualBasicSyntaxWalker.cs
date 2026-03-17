using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Scip;

namespace ScipDotnet;

/// <summary>
/// Walks a single VisualBasic syntax tree and produces a SCIP <code>Document</code>.
/// Emits occurrences with appropriate SymbolRole flags including Definition,
/// Import, ReadAccess, WriteAccess, and ForwardDefinition.
/// </summary>
public class ScipVisualBasicSyntaxWalker : VisualBasicSyntaxWalker
{
    private readonly SemanticModel _semanticModel;
    private readonly ScipDocumentIndexer _scipDocumentIndexer;

    public ScipVisualBasicSyntaxWalker(ScipDocumentIndexer scipSymbolFormatter, SemanticModel semanticModel, SyntaxWalkerDepth depth = SyntaxWalkerDepth.Node) : base(depth)
    {
        _scipDocumentIndexer = scipSymbolFormatter;
        _semanticModel = semanticModel;
    }

    /// <summary>
    /// Determines whether a reference occurrence is a write access by checking
    /// if the identifier is on the left-hand side of an assignment statement.
    /// </summary>
    /// <param name="node">The syntax node for the identifier reference.</param>
    /// <returns>SymbolRole.WriteAccess if write, SymbolRole.ReadAccess otherwise.</returns>
    private static int GetAccessRole(SyntaxNode node)
    {
        var parent = node.Parent;

        if (parent is AssignmentStatementSyntax assignment && assignment.Left == node)
            return (int)SymbolRole.WriteAccess;

        return (int)SymbolRole.ReadAccess;
    }

    /// <summary>
    /// Computes the ForwardDefinition flag for definitions that lack a body,
    /// such as MustOverride or Declare (extern) declarations.
    /// </summary>
    /// <param name="symbol">The Roslyn symbol being defined.</param>
    /// <returns>SymbolRole.ForwardDefinition flag or 0.</returns>
    private static int GetForwardDefinitionRole(ISymbol symbol)
    {
        return symbol switch
        {
            IMethodSymbol { IsAbstract: true } => (int)SymbolRole.ForwardDefinition,
            IMethodSymbol { IsExtern: true } => (int)SymbolRole.ForwardDefinition,
            IPropertySymbol { IsAbstract: true } => (int)SymbolRole.ForwardDefinition,
            IEventSymbol { IsAbstract: true } => (int)SymbolRole.ForwardDefinition,
            _ => 0
        };
    }

    /// <summary>
    /// Emits a definition occurrence with appropriate role flags.
    /// </summary>
    private void EmitDefinition(ISymbol? symbol, Location location, SyntaxNode node)
    {
        if (symbol == null) return;
        var roles = (int)SymbolRole.Definition | GetForwardDefinitionRole(symbol);
        _scipDocumentIndexer.VisitOccurrence(symbol, location, roles, node);
    }

    public override void VisitIdentifierName(IdentifierNameSyntax node)
    {
        var symbol = _semanticModel.GetSymbolInfo(node).Symbol;
        var roles = GetAccessRole(node);
        _scipDocumentIndexer.VisitOccurrence(symbol, node.GetLocation(), roles, node);
        base.VisitIdentifierName(node);
    }

    public override void VisitImportsStatement(ImportsStatementSyntax node)
    {
        foreach (var clause in node.ImportsClauses)
        {
            if (clause is SimpleImportsClauseSyntax simpleClause)
            {
                var symbol = _semanticModel.GetSymbolInfo(simpleClause.Name).Symbol;
                _scipDocumentIndexer.VisitOccurrence(symbol, simpleClause.Name.GetLocation(), (int)SymbolRole.Import, simpleClause.Name);
            }
        }

        base.VisitImportsStatement(node);
    }

    public override void VisitClassStatement(ClassStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitClassStatement(node);
    }

    public override void VisitModuleStatement(ModuleStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitModuleStatement(node);
    }

    public override void VisitEnumStatement(EnumStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitEnumStatement(node);
    }

    public override void VisitCatchStatement(CatchStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.IdentifierName.Identifier.GetLocation(), node);
        base.VisitCatchStatement(node);
    }

    public override void VisitSubNewStatement(SubNewStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.NewKeyword.GetLocation(), node);
        base.VisitSubNewStatement(node);
    }

    public override void VisitDelegateStatement(DelegateStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitDelegateStatement(node);
    }

    public override void VisitEventStatement(EventStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitEventStatement(node);
    }

    public override void VisitInterfaceStatement(InterfaceStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitInterfaceStatement(node);
    }

    public override void VisitPropertyStatement(PropertyStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitPropertyStatement(node);
    }

    public override void VisitStructureStatement(StructureStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitStructureStatement(node);
    }

    public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        foreach (var identifiers in node.Names)
        {
            EmitDefinition(_semanticModel.GetDeclaredSymbol(identifiers), identifiers.Identifier.GetLocation(), identifiers);
        }
        base.VisitVariableDeclarator(node);
    }

    public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitEnumMemberDeclaration(node);
    }

    public override void VisitMethodStatement(MethodStatementSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitMethodStatement(node);
    }

    public override void VisitParameter(ParameterSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitParameter(node);
    }

    public override void VisitTypeParameter(TypeParameterSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitTypeParameter(node);
    }

    public override void VisitExpressionRangeVariable(ExpressionRangeVariableSyntax node)
    {
        if (node.NameEquals != null)
        {
            EmitDefinition(_semanticModel.GetDeclaredSymbol(node.NameEquals.Identifier), node.NameEquals.Identifier.GetLocation(), node);
        }
        base.VisitExpressionRangeVariable(node);
    }

    public override void VisitAggregationRangeVariable(AggregationRangeVariableSyntax node)
    {
        if (node.NameEquals != null)
        {
            EmitDefinition(_semanticModel.GetDeclaredSymbol(node.NameEquals.Identifier), node.NameEquals.Identifier.GetLocation(), node);
        }
        base.VisitAggregationRangeVariable(node);
    }

    public override void VisitCollectionRangeVariable(CollectionRangeVariableSyntax node)
    {
        EmitDefinition(_semanticModel.GetDeclaredSymbol(node), node.Identifier.GetLocation(), node);
        base.VisitCollectionRangeVariable(node);
    }
}