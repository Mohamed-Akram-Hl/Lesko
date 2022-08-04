using System;
using System.Collections.Generic;

namespace Lesko.CodeAnalysis.Syntax
{
    public static class SyntaxFacts
    {
        public static int GetUnaryOperatorPrecedence(this SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.PlusToken:
                case SyntaxKind.MinusToken:
                case SyntaxKind.BangToken:
                case SyntaxKind.TildeToken:
                    return 6;

                default:
                    return 0;
            }
        }

        public static int GetBinaryOperatorPrecedence(this SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.PowerToken:
                    return 6;
                case SyntaxKind.StarToken:
                case SyntaxKind.SlashToken:
                case SyntaxKind.ModToken:
                    return 5;

                case SyntaxKind.PlusToken:
                case SyntaxKind.MinusToken:
                    return 4;

                case SyntaxKind.EqualsEqualsToken:
                case SyntaxKind.BangEqualsToken:
                case SyntaxKind.LessToken:
                case SyntaxKind.LessOrEqualsToken:
                case SyntaxKind.GreaterToken:
                case SyntaxKind.GreaterOrEqualsToken:
                    return 3;

                case SyntaxKind.AmpersandToken:
                case SyntaxKind.AmpersandAmpersandToken:
                    return 2;

                case SyntaxKind.PipeToken:
                case SyntaxKind.PipePipeToken:
                case SyntaxKind.HatToken:
                    return 1;

                default:
                    return 0;
            }
        }
        public static bool IsComment(this SyntaxKind kind)
        {
            return kind == SyntaxKind.SingleLineCommentToken ||
                   kind == SyntaxKind.MultiLineCommentToken;
        }

        public static SyntaxKind GetKeywordKind(string text)
        {
            switch (text)
            {
                case "arreter":
                    return SyntaxKind.BreakKeyword;
                case "continuer":
                    return SyntaxKind.ContinueKeyword;
                case "sinon":
                    return SyntaxKind.ElseKeyword;
                case "faux":
                    return SyntaxKind.FalseKeyword;
                case "pour":
                    return SyntaxKind.ForKeyword;
                case "fonction":
                    return SyntaxKind.FunctionKeyword;
                case "si":
                    return SyntaxKind.IfKeyword;
                case "let":
                    return SyntaxKind.LetKeyword;
                case "retourner":
                    return SyntaxKind.ReturnKeyword;
                case "jusqua":
                    return SyntaxKind.ToKeyword;
                case "vrai":
                    return SyntaxKind.TrueKeyword;
                case "var":
                    return SyntaxKind.VarKeyword;
                case "tantque":
                    return SyntaxKind.WhileKeyword;
                case "faire":
                    return SyntaxKind.DoKeyword;
                case "ou":
                    return SyntaxKind.PipePipeToken;
                case "and":
                    return SyntaxKind.AmpersandAmpersandToken;
                default:
                    return SyntaxKind.IdentifierToken;
            }
        }

        public static IEnumerable<SyntaxKind> GetUnaryOperatorKinds()
        {
            var kinds = (SyntaxKind[]) Enum.GetValues(typeof(SyntaxKind));
            foreach (var kind in kinds)
            {
                if (GetUnaryOperatorPrecedence(kind) > 0)
                    yield return kind;
            }
        }

        public static IEnumerable<SyntaxKind> GetBinaryOperatorKinds()
        {
            var kinds = (SyntaxKind[]) Enum.GetValues(typeof(SyntaxKind));
            foreach (var kind in kinds)
            {
                if (GetBinaryOperatorPrecedence(kind) > 0)
                    yield return kind;
            }
        }

        public static string GetText(SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.PlusToken:
                    return "+";
                case SyntaxKind.MinusToken:
                    return "-";
                case SyntaxKind.StarToken:
                    return "*";
                case SyntaxKind.SlashToken:
                    return "/";
                case SyntaxKind.PowerToken:
                    return "**";
                case SyntaxKind.ModToken:
                    return "%";
                case SyntaxKind.BangToken:
                    return "!";
                case SyntaxKind.EqualsToken:
                    return "=";
                case SyntaxKind.TildeToken:
                    return "~";
                case SyntaxKind.LessToken:
                    return "<";
                case SyntaxKind.LessOrEqualsToken:
                    return "<=";
                case SyntaxKind.GreaterToken:
                    return ">";
                case SyntaxKind.GreaterOrEqualsToken:
                    return ">=";
                case SyntaxKind.AmpersandToken:
                    return "&";
                case SyntaxKind.AmpersandAmpersandToken:
                    return "&&";
                case SyntaxKind.PipeToken:
                    return "|";
                case SyntaxKind.PipePipeToken:
                    return "||";
                case SyntaxKind.HatToken:
                    return "^";
                case SyntaxKind.EqualsEqualsToken:
                    return "==";
                case SyntaxKind.BangEqualsToken:
                    return "!=";
                case SyntaxKind.OpenParenthesisToken:
                    return "(";
                case SyntaxKind.CloseParenthesisToken:
                    return ")";
                case SyntaxKind.OpenBraceToken:
                    return "{";
                case SyntaxKind.CloseBraceToken:
                    return "}";
                case SyntaxKind.ColonToken:
                    return ":";
                case SyntaxKind.CommaToken:
                    return ",";
                case SyntaxKind.BreakKeyword:
                    return "arreter";
                case SyntaxKind.ContinueKeyword:
                    return "continuer";
                case SyntaxKind.ElseKeyword:
                    return "sinon";
                case SyntaxKind.FalseKeyword:
                    return "faux";
                case SyntaxKind.ForKeyword:
                    return "pour";
                case SyntaxKind.FunctionKeyword:
                    return "fonction";
                case SyntaxKind.IfKeyword:
                    return "si";
                case SyntaxKind.LetKeyword:
                    return "let";
                case SyntaxKind.ReturnKeyword:
                    return "retourner";
                case SyntaxKind.ToKeyword:
                    return "jusqua";
                case SyntaxKind.TrueKeyword:
                    return "vrai";
                case SyntaxKind.VarKeyword:
                    return "var";
                case SyntaxKind.WhileKeyword:
                    return "tantque";
                case SyntaxKind.DoKeyword:
                    return "faire";
                default:
                    return null;
            }
        }
    }
}