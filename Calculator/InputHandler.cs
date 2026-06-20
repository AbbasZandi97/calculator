namespace Calculator
{
    // this class only gets the inputs as raw strings
    static class InputHandler
    {

        public static double GetValidInput(string kind)
        {

            if (kind.Equals("first") || kind.Equals("First"))
            {

                MessagePrinter.PrintEnterFirstInput();

            }
            else if (kind.Equals("second") || kind.Equals("Second")) 
            {

                MessagePrinter.PrintEnterSecondInput();
            }
            else
            {
                throw new ArgumentException("Arguman for GetValidInput is not valid");
            }

            return ValidateInput();
        }


        public static double ValidateInput()
        {
            string input;
            
            while (true)
            {
                input = Console.ReadLine();
                if (Validator.IsInputValid(input))
                    break;
                MessagePrinter.PrintInvalidInput();
            }

            return double.Parse(input);
        }




        public static string GetValidChoice()
        {
            string choice;
            MessagePrinter.PrintEnterChoice();

            while (true)
            {
                choice = Console.ReadLine();
                
                if (Validator.IsChoiceValid(choice))
                {
                    break;
                }

                MessagePrinter.PrintInvalidChoice();
            }

            return choice;
        }





    }
}
