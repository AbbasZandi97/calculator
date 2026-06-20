namespace Calculator
{
    // This class picks the appropriate process for the selected operator.
    static class OperationStrategy
    {
        public static double SelectOperation(double firstNum, double secondNum, string choice)
        {
            return choice switch
            {
                "A" or "a" => Calculator.Sum(firstNum, secondNum),
                "S" or "s" => Calculator.Subtract(firstNum, secondNum),
                "M" or "m" => Calculator.Multiply(firstNum, secondNum),
                "D" or "d" => Calculator.Divide(firstNum, secondNum),
                _ => throw new ArgumentException($"Invalid operation '{choice}'.", nameof(choice)),
            };
        }
    }
}
