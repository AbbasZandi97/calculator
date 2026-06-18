namespace Calculator
{
    // this class only gets the inputs as raw strings
    internal class InputHandler
    {
        public string FirstInput { get; private set; }
        public string SecondInput { get; private set; }
        public string Operator { get; private set; }


        public void ReadInputs()
        {
            Console.WriteLine("Enter 1st input: ");
            FirstInput = Console.ReadLine();

            Console.WriteLine("Enter 2nd input: ");
            SecondInput = Console.ReadLine();
        }

        private void ReadOperator()
        {
            Console.WriteLine("Choose the operator:");
            Console.WriteLine("[A]dd the values.");
            Console.WriteLine("[S]ubtract the values.");
            Console.WriteLine("[M]ultiply the values.");
            Console.WriteLine("[D]ivide the values.");
            Operator = Console.ReadLine();
        }

    }
}
