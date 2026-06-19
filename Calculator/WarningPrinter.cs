using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class WarningPrinter
    {
        public static void PrintInvalidInput()
        {
            Console.WriteLine("Entered Input is not valid.");
        }

        public static void PrintInvalidOperator()
        {
            Console.WriteLine("Entered Operator is not valid.");
        }
    }
}
