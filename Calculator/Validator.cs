using System.Globalization;

namespace Calculator
{
    // this class validates the inputs and operator
    internal class Validator
    {
        
        public static bool IsInputValid(string input)
        {
            if (double.TryParse(input, out _))
                return true;

            return false;
        }


        public static bool IsChoiceValid(string op)
        {
            switch(op)
            {
                case "A":
                case "a":
                case "S":
                case "s":
                case "M":
                case "m":
                case "D":
                case "d":
                    return true;
                default:
                    return false;

            }
        }
    }
}
