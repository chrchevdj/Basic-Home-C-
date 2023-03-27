namespace Class02.Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 3:
            Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:
            Test Data:
            Input the First Number: 5
            Input the Second Number: 8
            Expected Output:
            After Swapping:
            First Number: 8
            Second Number: 5
             */

            Console.WriteLine("Input the First Number:");
            int inputFirst = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Input the Second Number:");
            int inputSecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Before");
            Console.WriteLine($"First Number: {inputFirst}");
            Console.WriteLine($"First Number: {inputSecond}");
            Console.WriteLine("After");
            Console.WriteLine($"First Number: {inputSecond}");
            Console.WriteLine($"First Number: {inputFirst}");

        }
    }
}