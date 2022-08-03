using System;
using Lesko.CodeAnalysis.Symbols;

namespace Lesko.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        public abstract TypeSymbol Type { get; }
    }
}
