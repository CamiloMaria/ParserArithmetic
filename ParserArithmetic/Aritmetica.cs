using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserArithmetic
{
    internal class Aritmetica : AritmeticaBaseVisitor<int>
    {
        public override int VisitAritmetica([NotNull] AritmeticaParser.AritmeticaContext context)
        {
            Console.WriteLine($"Visitando Aritmetica: {context.GetText()}");
            return base.VisitAritmetica(context);   
        }

        public override int VisitExpresion([NotNull] AritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine($"Visitando Expresion: {context.GetText()}");
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] AritmeticaParser.FactorContext context)
        {
            Console.WriteLine($"Visitando Factor: {context.GetText()}");
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] AritmeticaParser.TerminoContext context)
        {
            Console.WriteLine($"Visitando Termino: {context.GetText()}");
            return base.VisitTermino(context);
        }
    }
}
