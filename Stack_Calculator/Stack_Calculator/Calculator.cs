using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Calculator
{
    class Calculator
    {
        Convertingtype convert;

        public double Postfix_Calculator(List<string> formula) {
            double value = 0.0;
            string op = string.Empty;
            convert = new Convertingtype();
            Stack<double> number = new Stack<double>();

            for (int idx = 0; idx < formula.Count; idx++) {
                if (convert.OperatorPriority(formula[idx].ToString()) == Sign.NotOperator) {
                    number.Push(formula[idx].ToString().ParseToDouble());
                }
                else {
                    op = formula[idx].ToString();
                    value = ExecuteCalculator(number.Pop().ToString().ParseToDouble(), number.Pop().ToString().ParseToDouble(), op);
                    number.Push(value);
                }
            }
            return value;
        }

        private double ExecuteCalculator(double fstNum, double secNum, string oper) {
            switch (oper) {
                case "*":
                    return fstNum * secNum;
                case "/":
                    return fstNum / secNum;
                case "+":
                    return fstNum + secNum;
                case "-":
                    return fstNum - secNum;
                default:
                    throw new Exception($"Unknoewn Operator '{oper}'");
            }
        }
    }
}