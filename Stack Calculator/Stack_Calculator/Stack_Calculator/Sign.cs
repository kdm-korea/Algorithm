namespace Stack_Calculator
{
    public static class Sign
    {
        public static readonly int NotOperator = -1;
        public static readonly int StartBracket = 1;
        public static readonly int EndBracket = 0;

        public static int OperatorPriority(string oper) {
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
