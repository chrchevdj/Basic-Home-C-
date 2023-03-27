namespace Class03.Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Make a new console application called StudentGroup
            Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
            Get a number from the console between 1 and 2 and print the students from that group in the console.
            Ex: studentsG1 ["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            Test Data:
            Enter student group: ( there are 1 and 2 )
            1
            Expected Output:
            The Students in G1 are:
            Zdravko
            Petko
            Stanko
            Branko
            Trajko
             */
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Colic", "Brus lee", "Vanco", "Gorgi", "Silvester" };

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            int input = int.Parse(Console.ReadLine());

            if(input != 1 || input != 2) 
            {
                Console.WriteLine("Please choose between 1 and 2");
            }
            if(input == 1)
            {
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
                return;
            }
            if(input == 2)
            {
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
        }   
    }
}