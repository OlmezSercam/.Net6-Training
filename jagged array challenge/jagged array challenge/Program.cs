using System.Security.Cryptography.X509Certificates;

namespace jagged_array_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string[][] friendsAndFamily = new string[][]
            {
                new string []  {"Sercan", "Ercan"},
                new string []  { "Mert", "İnan" },
                new string []  { "Eren", "Furkan" }
            };


            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.ReadKey();*/
            int[] studentsGrades = new int[] { 15, 20, 18, 10, 12, 15 };
            double averageResult = GetAverage(studentsGrades);
            foreach(int grade in studentsGrades)
            {
                Console.WriteLine("{0}",grade);
            }
            Console.WriteLine("The average is {0}", averageResult);
            Console.ReadKey();
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;

    }
}
