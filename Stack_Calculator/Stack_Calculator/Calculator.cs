using System;
using System.Collections.Generic;

namespace Stack_Calculator
{
    class Calculator
    {
        public double Postfix_Calculator(List<string> formula) {
            double value = 0.0, fst = 0.0, sec = 0.0;
            string op = string.Empty;
            Stack<double> number = new Stack<double>();

            for (int idx = 0; idx < formula.Count; idx++) {
                if (Sign.OperatorPriority(formula[idx].ToString()) == Sign.NotOperator) {
                    number.Push(formula[idx].ToString().ParseToDouble());
                }
                else {
                    op = formula[idx].ToString();
                    sec = number.Pop().ToString().ParseToDouble();
                    fst = number.Pop().ToString().ParseToDouble();
                    value = ExecuteCalculator(fst, sec, op);
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