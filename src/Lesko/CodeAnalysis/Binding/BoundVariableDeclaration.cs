using Lesko.CodeAnalysis.Symbols;

namespace Lesko.CodeAnalysis.Binding
{
    internal sealed class BoundVariableDeclaration : BoundStatement
    {
        public BoundVariableDeclaration(VariableSymbol variable, BoundExpression initializer)
        {
            Variable = variable;
            Initializer = initializer;
        }

        public override BoundNodeKind Kind => BoundNodeKind.VariableDeclaration;
        public VariableSymbol Variable { get; }
        public BoundExpression Initializer { get; }
    }
}
