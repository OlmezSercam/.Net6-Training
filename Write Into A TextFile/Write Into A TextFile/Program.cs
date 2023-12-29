namespace Write_Into_A_TextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 - Writing into the textfile
            string[] lines = { "first line", "Second line", "Third Line" };
            File.WriteAllLines(@"C:\C# TextFile\Write.txt", lines);
            
            //Example 2 - Writing into the textfile
            Console.WriteLine("Please give the file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\C# TextFile\"+ fileName +".txt", input);
            
            //Example 3 - Writing into the textfile
            using(StreamWriter file = new StreamWriter(@"C:\C# TextFile\MyTextFile.txt")) 
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
