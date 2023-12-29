using System;
using System.Text.RegularExpressions;

namespace Regex_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);
            string text = System.IO.File.ReadAllText(@"C:\C# TextFile\input2.txt");
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                int integerValue;
                if (int.TryParse(match.Value, out integerValue))
                {
                    Console.WriteLine((char)integerValue+" ");
                }
            }
            Console.ReadLine();
            
        }
    }
}
