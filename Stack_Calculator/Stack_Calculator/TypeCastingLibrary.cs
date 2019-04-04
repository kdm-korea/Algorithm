namespace Stack_Calculator
{
    public static class TypeCastingLibrary
    {
        public static double ParseToDouble(this string s) {
            double.TryParse(s, out double value);
            return value;
        }
    }
}
