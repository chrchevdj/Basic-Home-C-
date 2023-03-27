namespace Class04.Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Calculate the sum of the digits in the number
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            // Print the sum of the digits
            Console.WriteLine("The sum of the digits in the number is: " + sum);

            // Prompt the user to enter a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Split the sentence into words
            string[] words = sentence.Split(' ');

            // Find the largest word
            string largestWord = "";
            foreach (string word in words)
            {
                if (word.Length > largestWord.Length)
                {
                    largestWord = word;
                }
            }

            // Print the largest word
            Console.WriteLine("The largest word in the sentence is: " + largestWord);
        }
    }
}