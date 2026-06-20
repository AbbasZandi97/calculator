namespace Calculator
{
    // this class handles the main flow of program

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator App");
            double firstInput = InputHandler.GetValidInput("First");
            double secondInput = InputHandler.GetValidInput("Second");
            string choice = InputHandler.GetValidChoice();
            double result = OperationStrategy.SelectOperation(firstInput, secondInput, choice);
            MessagePrinter.PrintAnswer(result);
            
        }
    }
}
