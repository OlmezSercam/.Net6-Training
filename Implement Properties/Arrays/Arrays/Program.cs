namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize array grades  
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 10;
            grades[3] = 9;
            grades[4] = 12;
            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            // Assign value to array grades at index 0
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 15, 14 };


            //third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 13, 12 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();
        }
    }
}
