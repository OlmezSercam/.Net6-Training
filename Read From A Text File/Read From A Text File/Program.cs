namespace Read_From_A_Text_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Reading text
            string text = System.IO.File.ReadAllText(@"C:\C# TextFile\Read.txt");
            Console.WriteLine("TextFile contains following text: {0}",text);

            //Example 2 - Reading Text
            string[] Lines = System.IO.File.ReadAllLines(@"C:\C# TextFile\Read.txt");
            Console.WriteLine("Contents of TextFile = ");
            foreach (string line in Lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();
        }
    }
}
