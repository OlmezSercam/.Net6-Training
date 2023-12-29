namespace Parsing_Game_Reading_Writing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\C# TextFile\input.txt");
            

            foreach (string line in lines)
            {

                if (line.Contains("split"))
                {
                    string[] lines = line.Split(' ');
                    Console.WriteLine(line.Split(" "));
                }
            }
            Console.Read();
        }
    }
}
