using System;
using System.Text.RegularExpressions;

namespace RegexE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";    // aranacak anahtar pattern
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";  // aranacakları yer
            
            MatchCollection matchCollection = regex.Matches(text);  // arama anı

            Console.WriteLine("{0} hits found: \n {1}",matchCollection.Count,text);  // aradıklarımızın sayılması 

            foreach (Match hit in matchCollection)  // arama başına yazdırma ve tutan şeylerin kendileri
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}
