namespace Class03.Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Task 1
            Make a console application called SumOfEven. Inside it create an array of 6 integers. Find and print the sum of the even numbers from the array:
            Test Data:
            Enter integer no.1:
            4
            Enter integer no.1:
            3
            Enter integer no.1:
            7
            Enter integer no.1:
            3
            Enter integer no.1:
            2
            Enter integer no.1:
            8
            Expected Output:
            The result is: 14
             */

            Console.WriteLine("SumOfEven");
            int[] ints = new int[6];
            Console.WriteLine("Enter integer no.1");
            ints[0]= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.2");
            ints[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.3");
            ints[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.4");
            ints[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.5");
            ints[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer no.6");
            ints[5] = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                result += ints[i];
            }
            Console.WriteLine(result);
        }
    }
}