using System;

namespace Stack_Calculator
{
    class Program
    {
        static void Main(string[] args) {
            Calculator execute = new Calculator();
            Convertingtype convert = new Convertingtype();

            string formula = "(32+2)*20/2";

            double value = execute.Postfix_Calculator(convert.ConvertPostfix(formula));

            Console.WriteLine(value);
        }
    }
}
