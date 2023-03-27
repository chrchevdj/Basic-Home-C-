using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

namespace Class02.Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 1
            Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the Operation: +
            Expected Output:
            The result is: 25
            */
            Console.WriteLine("Enter the First number:");
            int inputFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int inputSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operation: +, - , * , / ");
            string inputOperation = Console.ReadLine();

            int result = 0;
            switch (inputOperation)
            {
                case "+":
                    result = inputFirst + inputSecond;
                    break;
                case "-":
                    result = inputFirst - inputSecond;
                    break;
                case "*":
                    result = inputFirst * inputSecond;
                    break;
                case "/":
                    result = inputFirst / inputSecond;
                    break;

            }
            Console.WriteLine($"The result is: {result}");
        }
    }
}