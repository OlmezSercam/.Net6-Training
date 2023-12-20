using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i= -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("for loop is over");
            int ii = 3;
            while (ii > -4)
            {
                Console.WriteLine(ii);
                ii--;
            }
            Console.WriteLine("while loop is over");
            Console.Read();
        }
    }
}
