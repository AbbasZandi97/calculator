using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    // This class is responsible for all printing messages within the whole code.
    internal class MessagePrinter
    {

        public static void PrintEnterFirstInput()
        {
            Console.WriteLine("Enter 1st input: ");
        }

        public static void PrintEnterSecondInput()
        {
            Console.WriteLine("Enter 2nd input: ");
        }

        public static void PrintEnterChoice()
        {
            Console.WriteLine("Choose the operator:");
            Console.WriteLine("[A]dd the values.");
            Console.WriteLine("[S]ubtract the values.");
            Console.WriteLine("[M]ultiply the values.");
            Console.WriteLine("[D]ivide the values.");
        }

        public static void PrintInvalidInput()
        {
            Console.WriteLine("Entered Input is not valid.");
            Console.WriteLine("Try again: ");
        }

        public static void PrintInvalidChoice()
        {
            Console.WriteLine("Entered Option is not valid.");
            Console.WriteLine("Plese enter correct choice: ");
        }


        public static void PrintAnswer(double value)
        {
            Console.WriteLine($"The answer is: {value}");
        }
    }
}
