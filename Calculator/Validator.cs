using System.Globalization;

namespace Calculator
{
    // this class validates the inputs and operator
    internal class Validator
    {
        
        public bool IsInputValid(string input)
        {
            if (double.TryParse(input, out _))
                return true;

            return false;
        }


        public bool IsOperatorValid(string op)
        {
            switch(op)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return true;
                default:
                    return false;

            }
        }
    }
}
