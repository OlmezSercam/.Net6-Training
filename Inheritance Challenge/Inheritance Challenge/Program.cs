using System.Security.Cryptography.X509Certificates;

namespace Inheritance_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Sercan = new Employee("Ölmez", "Sercan", 0);

            Sercan.Work();
            Sercan.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 11111);

            chuckNorris.Lead();

            Trainee Michelle = new Trainee(32, 8, "Gartner", "Michelle", 1000);
            Michelle.Learn();
            Michelle.Work();

            Console.ReadKey();
        }
    }

}
