using System;

namespace Stack_Calculator
{
    class Program
    {
        static Convertingtype convert;

        static void Main(string[] args) {
            Calculator execute = new Calculator();
            convert = new Convertingtype();

            string formula = " ( 3 2 + 2 ) * ( 2 0 / 2 ) + 3 * 4 + 2 ".Replace(" ","");

            Console.WriteLine($"Infix_Formula : {formula}");

            Prt_PostfixFormula(formula);

            Console.WriteLine($"Value : {execute.Postfix_Calculator(convert.ConvertPostfix(formula))}");
        }

        private static void Prt_PostfixFormula(string formula) {
            convert = new Convertingtype();
            var tmp = convert.ConvertPostfix(formula);

            Console.Write("Postfix_Formula : ");
            foreach (var item in tmp) {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
