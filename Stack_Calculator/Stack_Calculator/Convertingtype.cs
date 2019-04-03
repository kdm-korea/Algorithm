using System.Collections.Generic;
using System.Text;

namespace Stack_Calculator
{
    class Convertingtype
    {
        private Stack<string> operate = new Stack<string>();
        private List<string> array = new List<string>();

        private void PopOperator(StringBuilder currentData, int operKind, string oper) {
            if (!currentData.ToString().Length.Equals(0)) {
                array.Add(currentData.ToString());
                currentData.Clear();
            }
            if (operKind == Sign.EndBracket) {
                PopOperatorStack();
            }
            else {
                PopOperatorStack(oper);
            }
            operate.Push(oper);
        }

        public List<string> ConvertPostfix(string formula) {
            int operKind;
            StringBuilder tmp = new StringBuilder();

            for (int idx = 0; idx < formula.Length; idx++) {

                operKind = OperatorPriority(formula[idx].ToString());
                if (operKind == Sign.NotOperator) {
                    tmp.Append(formula[idx]);
                }
                else {
                    PopOperator(tmp, operKind, formula[idx].ToString());
                }
            }
            array.Add(tmp.ToString());
            array.Add(operate.Peek());
            operate.Pop();

            return array;
        }

        private void PopOperatorStack() {
            for (int idx = 0; idx < operate.Count; idx++) {
                if (OperatorPriority(operate.Peek().ToString()) != Sign.StartBracket) {
                    array.Add(operate.Peek().ToString());
                }
                operate.Pop();
            }
        }

        private void PopOperatorStack(string oper) {
            for (int idx = 0; idx < operate.Count; idx++) {
                if (OperatorPriority(operate.Peek().ToString()) <= OperatorPriority(oper) && OperatorPriority(operate.Peek().ToString()) > Sign.StartBracket) {
                    array.Add(operate.Peek().ToString());
                    operate.Pop();
                }
                else {
                    operate.Pop();
                    return;
                }
            }
        }

        public int OperatorPriority(string oper) {
            switch (oper) {
                case "*":
                    return 3;
                case "/":
                    return 3;
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "(":
                    return 1;
                case ")":
                    return 0;
                default:
                    return -1;
            }
        }
    }
}