using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;

namespace Lesko.CodeAnalysis.Symbols
{
    internal static class BuiltinFunctions
    {
        public static readonly FunctionSymbol Print = new FunctionSymbol("ecrire", ImmutableArray.Create(new ParameterSymbol("text", TypeSymbol.Any)), TypeSymbol.Void);
        public static readonly FunctionSymbol Input = new FunctionSymbol("lire", ImmutableArray<ParameterSymbol>.Empty, TypeSymbol.String);
        public static readonly FunctionSymbol Rnd = new FunctionSymbol("alea", ImmutableArray.Create(new ParameterSymbol("max", TypeSymbol.Int)), TypeSymbol.Int);

        public static readonly FunctionSymbol abs = new FunctionSymbol("absolu", ImmutableArray.Create(new ParameterSymbol("number", TypeSymbol.Float)), TypeSymbol.Float);
        public static readonly FunctionSymbol sqrt = new FunctionSymbol("racine", ImmutableArray.Create(new ParameterSymbol("number", TypeSymbol.Float)), TypeSymbol.Float);
        public static readonly FunctionSymbol round = new FunctionSymbol("arrondir", ImmutableArray.Create(new ParameterSymbol("number", TypeSymbol.Float)), TypeSymbol.Float);

        public static readonly FunctionSymbol type = new FunctionSymbol("type", ImmutableArray.Create(new ParameterSymbol("any", TypeSymbol.Any)), TypeSymbol.Any);
        public static readonly FunctionSymbol len = new FunctionSymbol("long", ImmutableArray.Create(new ParameterSymbol("string", TypeSymbol.String)), TypeSymbol.Int);
        public static readonly FunctionSymbol Char = new FunctionSymbol("Char", ImmutableArray.Create(new ParameterSymbol("string", TypeSymbol.String), new ParameterSymbol("number", TypeSymbol.Int)), TypeSymbol.String);
        internal static IEnumerable<FunctionSymbol> GetAll()
            => typeof(BuiltinFunctions).GetFields(BindingFlags.Public | BindingFlags.Static)
                                       .Where(f => f.FieldType == typeof(FunctionSymbol))
                                       .Select(f => (FunctionSymbol)f.GetValue(null));
    }
}