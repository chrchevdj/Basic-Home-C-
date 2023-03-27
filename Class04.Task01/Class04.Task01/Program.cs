namespace Class04.Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (input.Length < 5)
            {
                Console.WriteLine("The string is too short to print its last 5 characters.");
            }
            else
            {
                Console.WriteLine("The last 5 characters of the string are: " + input.Substring(input.Length - 5));
            }
        }
    }
}