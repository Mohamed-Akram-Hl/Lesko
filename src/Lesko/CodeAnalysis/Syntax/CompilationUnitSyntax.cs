using System.Collections.Immutable;

namespace Lesko.CodeAnalysis.Syntax
{
    public sealed class CompilationUnitSyntax : SyntaxNode
    {
        public CompilationUnitSyntax(SyntaxTree syntaxTree, ImmutableArray<MemberSyntax> members, SyntaxToken endOfFileToken)
            : base(syntaxTree)
        {
            Members = members;
            EndOfFileToken = endOfFileToken;
        }

        public override SyntaxKind Kind => SyntaxKind.CompilationUnit;
        public ImmutableArray<MemberSyntax> Members { get; }
        public SyntaxToken EndOfFileToken { get; }
    }
}