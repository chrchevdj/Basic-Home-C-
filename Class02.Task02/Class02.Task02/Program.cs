namespace Class02.Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 2
            Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the four number: 30
            Expected Output:
            The average of 10, 15, 20 and 30 is: 18
             */

            Console.WriteLine("Enter the First number:");
            int inputFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int inputSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int inputThird = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the four number:");
            int inputFour = int.Parse(Console.ReadLine());

            int result = ((inputFirst + inputSecond + inputThird + inputFour) / 4);
            Console.WriteLine($"The average of{inputFirst} {inputSecond} {inputThird} {inputFour} is: {result}");


        }
    }
}