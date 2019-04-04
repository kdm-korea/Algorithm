using System.Collections.Generic;
using System.Text;

namespace Stack_Calculator
{
    class Convertingtype
    {
        private Stack<string> operate = new Stack<string>();
        private List<string> array = new List<string>();

        public List<string> ConvertPostfix(string formula) {
            int operKind;
            StringBuilder currentData = new StringBuilder();

            ClearMemory();
            for (int idx = 0; idx < formula.Length; idx++) {

                operKind = Sign.OperatorPriority(formula[idx].ToString());
                if (operKind == Sign.NotOperator) {
                    currentData.Append(formula[idx]);
                }
                else {
                    PopOperator(currentData, operKind, formula[idx].ToString());
                }
            }
            NotEmptyCurrentData(currentData);
            PopOperatorStack();

            return array;
        }

        private void PopOperator(StringBuilder currentData, int operKind, string oper) {
            NotEmptyCurrentData(currentData);

            if (operKind == Sign.EndBracket) {
                PopOperatorStack();
            }
            else {
                PopOperatorStack(oper);
                operate.Push(oper);
            }
        }

        private void PopOperatorStack() {
            int dept = operate.Count;
            for (int idx = 0; idx < dept; idx++) {
                if (Sign.OperatorPriority(operate.Peek().ToString()) != Sign.StartBracket) {
                    array.Add(operate.Pop().ToString());
                }
                else {
                    operate.Pop();
                    return;
                }
            }
        }

        private void PopOperatorStack(string currentOper) {
            int dept = operate.Count;
            for (int idx = 0; idx < dept; idx++) {
                if (Sign.OperatorPriority(operate.Peek().ToString()) < Sign.OperatorPriority(currentOper) || (Sign.OperatorPriority(currentOper.ToString()) == Sign.StartBracket)) {
                    return;
                }
                else {
                    array.Add(operate.Pop().ToString());
                }
            }
        }

        private void NotEmptyCurrentData(StringBuilder currentData) {
            if (!currentData.ToString().Length.Equals(0)) {
                array.Add(currentData.ToString());
                currentData.Clear();
            }
        }

        private void ClearMemory() {
            operate.Clear();
            array.Clear();
        }
    }
}