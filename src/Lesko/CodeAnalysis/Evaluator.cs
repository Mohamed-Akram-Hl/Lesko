using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Lesko.CodeAnalysis.Binding;
using Lesko.CodeAnalysis.Symbols;

namespace Lesko.CodeAnalysis
{
    internal sealed class Evaluator
    {
        private readonly BoundProgram _program;
        private readonly Dictionary<VariableSymbol, object> _globals;
        private readonly Dictionary<FunctionSymbol, BoundBlockStatement> _functions = new Dictionary<FunctionSymbol, BoundBlockStatement>();
        private readonly Stack<Dictionary<VariableSymbol, object>> _locals = new Stack<Dictionary<VariableSymbol, object>>();
        private Random _random;

        private object _lastValue;

        public Evaluator(BoundProgram program, Dictionary<VariableSymbol, object> variables)
        {
            _program = program;
            _globals = variables;
            _locals.Push(new Dictionary<VariableSymbol, object>());

            var current = program;
            while (current != null)
            {
                foreach (var kv in current.Functions)
                {
                    var function = kv.Key;
                    var body = kv.Value;
                    _functions.Add(function, body);
                }

                current = current.Previous;
            }
        }

        public object Evaluate()
        {
            var function = _program.MainFunction ?? _program.ScriptFunction;
            if (function == null)
                return null;

            var body = _functions[function];
            return EvaluateStatement(body);
        }

        private object EvaluateStatement(BoundBlockStatement body)
        {
            var labelToIndex = new Dictionary<BoundLabel, int>();

            for (var i = 0; i < body.Statements.Length; i++)
            {
                if (body.Statements[i] is BoundLabelStatement l)
                    labelToIndex.Add(l.Label, i + 1);
            }

            var index = 0;

            while (index < body.Statements.Length)
            {
                var s = body.Statements[index];

                switch (s.Kind)
                {
                    case BoundNodeKind.VariableDeclaration:
                        EvaluateVariableDeclaration((BoundVariableDeclaration)s);
                        index++;
                        break;
                    case BoundNodeKind.ExpressionStatement:
                        EvaluateExpressionStatement((BoundExpressionStatement)s);
                        index++;
                        break;
                    case BoundNodeKind.GotoStatement:
                        var gs = (BoundGotoStatement)s;
                        index = labelToIndex[gs.Label];
                        break;
                    case BoundNodeKind.ConditionalGotoStatement:
                        var cgs = (BoundConditionalGotoStatement)s;
                        var condition = (bool)EvaluateExpression(cgs.Condition);
                        if (condition == cgs.JumpIfTrue)
                            index = labelToIndex[cgs.Label];
                        else
                            index++;
                        break;
                    case BoundNodeKind.LabelStatement:
                        index++;
                        break;
                    case BoundNodeKind.ReturnStatement:
                        var rs = (BoundReturnStatement)s;
                        _lastValue = rs.Expression == null ? null : EvaluateExpression(rs.Expression);
                        return _lastValue;
                    default:
                        throw new Exception($"Unexpected node {s.Kind}");
                }
            }

            return _lastValue;
        }

        private void EvaluateVariableDeclaration(BoundVariableDeclaration node)
        {
            var value = EvaluateExpression(node.Initializer);
            _lastValue = value;
            Assign(node.Variable, value);
        }

        private void EvaluateExpressionStatement(BoundExpressionStatement node)
        {
            _lastValue = EvaluateExpression(node.Expression);
        }

        private object EvaluateExpression(BoundExpression node)
        {
            switch (node.Kind)
            {
                case BoundNodeKind.LiteralExpression:
                    return EvaluateLiteralExpression((BoundLiteralExpression)node);
                case BoundNodeKind.VariableExpression:
                    return EvaluateVariableExpression((BoundVariableExpression)node);
                case BoundNodeKind.AssignmentExpression:
                    return EvaluateAssignmentExpression((BoundAssignmentExpression)node);
                case BoundNodeKind.UnaryExpression:
                    return EvaluateUnaryExpression((BoundUnaryExpression)node);
                case BoundNodeKind.BinaryExpression:
                    return EvaluateBinaryExpression((BoundBinaryExpression)node);
                case BoundNodeKind.CallExpression:
                    return EvaluateCallExpression((BoundCallExpression)node);
                case BoundNodeKind.ConversionExpression:
                    return EvaluateConversionExpression((BoundConversionExpression)node);
                default:
                    throw new Exception($"Unexpected node {node.Kind}");
            }
        }

        private static object EvaluateLiteralExpression(BoundLiteralExpression n)
        {
            return n.Value;
        }

        private object EvaluateVariableExpression(BoundVariableExpression v)
        {
            if (v.Variable.Kind == SymbolKind.GlobalVariable)
            {
                return _globals[v.Variable];
            }
            else
            {
                var locals = _locals.Peek();
                return locals[v.Variable];
            }
        }

        private object EvaluateAssignmentExpression(BoundAssignmentExpression a)
        {
            var value = EvaluateExpression(a.Expression);
            Assign(a.Variable, value);
            return value;
        }

        private object EvaluateUnaryExpression(BoundUnaryExpression u)
        {
            var operand = EvaluateExpression(u.Operand);

            switch (u.Op.Kind)
            {
                case BoundUnaryOperatorKind.Identity:
                    try
                    {
                        return (int)operand;
                    }
                    catch
                    {
                        return (double)operand;
                    }
                case BoundUnaryOperatorKind.Negation:
                    try
                    {
                        return -(int)operand;
                    }
                    catch
                    {
                        return -(double)operand;
                    }
                case BoundUnaryOperatorKind.LogicalNegation:
                    return !(bool)operand;
                case BoundUnaryOperatorKind.not:
                    return !(bool)operand;
                case BoundUnaryOperatorKind.OnesComplement:
                    return ~(int)operand;
                default:
                    throw new Exception($"Unexpected unary operator {u.Op}");
            }
        }

        private object EvaluateBinaryExpression(BoundBinaryExpression b)
        {
            var left = EvaluateExpression(b.Left);
            var right = EvaluateExpression(b.Right);

            switch (b.Op.Kind)
            {
                case BoundBinaryOperatorKind.Addition:
                    {
                        if (b.Type == TypeSymbol.String)
                            return (string)left + (string)right;
                        var res = Convert.ToDouble(left) + Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (int)res;
                    }
                case BoundBinaryOperatorKind.Subtraction:
                    {
                        var res = Convert.ToDouble(left) - Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (int)res;
                    }
                case BoundBinaryOperatorKind.Multiplication:
                    {
                        var res = Convert.ToDouble(left) * Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (int)res;
                    }
                case BoundBinaryOperatorKind.Division:
                    {
                        var res = Convert.ToDouble(left) / Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return res;
                    }
                case BoundBinaryOperatorKind.Power:
                    {
                        var res = Math.Pow(Convert.ToDouble(left), Convert.ToDouble(right));
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (int)res;
                    }
                case BoundBinaryOperatorKind.Mod:
                    return (int)left % (int)right;
                case BoundBinaryOperatorKind.ModKey:
                    return (int)left % (int)right;
                case BoundBinaryOperatorKind.Div:
                    return (int)left / (int)right;
                case BoundBinaryOperatorKind.BitwiseAnd:
                    if (b.Type == TypeSymbol.Int)
                        return (int)left & (int)right;
                    else
                        return (bool)left & (bool)right;
                case BoundBinaryOperatorKind.BitwiseOr:
                    if (b.Type == TypeSymbol.Int)
                        return (int)left | (int)right;
                    else
                        return (bool)left | (bool)right;
                case BoundBinaryOperatorKind.BitwiseXor:
                    if (b.Type == TypeSymbol.Int)
                        return (int)left ^ (int)right;
                    else
                        return (bool)left ^ (bool)right;
                case BoundBinaryOperatorKind.LogicalAnd:
                    return (bool)left && (bool)right;
                case BoundBinaryOperatorKind.AndKey:
                    return (bool)left && (bool)right;
                case BoundBinaryOperatorKind.LogicalOr:
                    return (bool)left || (bool)right;
                case BoundBinaryOperatorKind.OrKey:
                    return (bool)left || (bool)right;
                case BoundBinaryOperatorKind.Equals:
                    {
                        if (b.Left.Type == TypeSymbol.Float ^ b.Right.Type == TypeSymbol.Float)
                        {
                            return Equals(Convert.ToDecimal(left), Convert.ToDecimal(right));
                        }
                        return Equals(left, right);
                    }
                case BoundBinaryOperatorKind.NotEquals:
                    {
                        if (b.Left.Type == TypeSymbol.Float ^ b.Right.Type == TypeSymbol.Float)
                        {
                            return !Equals(Convert.ToDecimal(left), Convert.ToDecimal(right));
                        }
                        return !Equals(left, right);
                    }
                case BoundBinaryOperatorKind.Less:
                    {
                        var res = Convert.ToDouble(left) < Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (bool)res;
                    }
                case BoundBinaryOperatorKind.LessOrEquals:
                    {
                        var res = Convert.ToDouble(left) <= Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (bool)res;
                    }
                case BoundBinaryOperatorKind.Greater:
                    {
                        var res = Convert.ToDouble(left) > Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (bool)res;
                    }
                case BoundBinaryOperatorKind.GreaterOrEquals:
                    {
                        var res = Convert.ToDouble(left) >= Convert.ToDouble(right);
                        if (b.Type == TypeSymbol.Float)
                            return res;
                        return (bool)res;
                    }
                default:
                    throw new Exception($"Unexpected binary operator {b.Op}");
            }
        }

        private object EvaluateCallExpression(BoundCallExpression node)
        {
            if (node.Function == BuiltinFunctions.Input)
            {
                return Console.ReadLine();
            }
            else if (node.Function == BuiltinFunctions.Print)
            {
                var message = EvaluateExpression(node.Arguments[0]);
                Console.WriteLine(message);
                return null;
            }
            else if (node.Function == BuiltinFunctions.Rnd)
            {
                var max = (int)EvaluateExpression(node.Arguments[0]);
                if (_random == null)
                    _random = new Random();

                return _random.Next(max);
            }
            else if (node.Function == BuiltinFunctions.abs)
            {
                var max = EvaluateExpression(node.Arguments[0]);

                return Math.Abs(Convert.ToDouble(max));
            }
            else if (node.Function == BuiltinFunctions.sqrt)
            {
                var max = EvaluateExpression(node.Arguments[0]);

                return Math.Sqrt(Convert.ToDouble(max));
            }
            else if (node.Function == BuiltinFunctions.round)
            {
                var max = EvaluateExpression(node.Arguments[0]);

                return Math.Round(Convert.ToDouble(max));
            }
            else if (node.Function == BuiltinFunctions.type)
            {
                var max = EvaluateExpression(node.Arguments[0]);

                if (max.GetType().Equals(typeof(int)))
                    return "entier";
                if (max.GetType().Equals(typeof(double)))
                    return "reel";
                if (max.GetType().Equals(typeof(string)))
                    return "chaine";
                if (max.GetType().Equals(typeof(bool)))
                    return "booleen";

                return null;
            }
            else if (node.Function == BuiltinFunctions.len)
            {
                var max = Convert.ToString(EvaluateExpression(node.Arguments[0]));

                return max.Length;
            }
            else
            {
                var locals = new Dictionary<VariableSymbol, object>();
                for (int i = 0; i < node.Arguments.Length; i++)
                {
                    var parameter = node.Function.Parameters[i];
                    var value = EvaluateExpression(node.Arguments[i]);
                    locals.Add(parameter, value);
                }

                _locals.Push(locals);

                var statement = _functions[node.Function];
                var result = EvaluateStatement(statement);

                _locals.Pop();

                return result;
            }
        }

        private object EvaluateConversionExpression(BoundConversionExpression node)
        {
            var value = EvaluateExpression(node.Expression);
            if (node.Type == TypeSymbol.Any)
                return value;
            else if (node.Type == TypeSymbol.Bool)
            {
                if (value.Equals("vrai"))
                {
                    value = "true";
                }
                else if (value.Equals("faux"))
                {
                    value = "false";
                }
                try
                {
                    return Convert.ToBoolean(value);
                }
                catch (Exception)
                {
                    return new Exception($"Can not Convert '{value}' to {node.Type}");
                }  
            }
            else if (node.Type == TypeSymbol.Int)
                try
                {
                    return Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    return new Exception($"Can not Convert '{value}' to {node.Type}");
                }
            else if (node.Type == TypeSymbol.Float)
                try
                {
                    return Convert.ToDouble(value);
                }
                catch (Exception)
                {
                    return new Exception($"Can not Convert '{value}' to {node.Type}");
                }          
            else if (node.Type == TypeSymbol.String)
                try
                {
                    return Convert.ToString(value);
                }
                catch (Exception)
                {
                    return new Exception($"Can not Convert '{value}' to {node.Type}");
                }
            else
                throw new Exception($"Unexpected type {node.Type}");
        }

        private void Assign(VariableSymbol variable, object value)
        {
            if (variable.Kind == SymbolKind.GlobalVariable)
            {
                _globals[variable] = value;
            }
            else
            {
                var locals = _locals.Peek();
                locals[variable] = value;
            }
        }
    }
}