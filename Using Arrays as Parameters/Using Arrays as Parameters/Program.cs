namespace Using_Arrays_as_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = { 1, 2, 3, 4, 5 };
            
            SunIsShining(happiness);
            foreach (int y in happiness) 
            {
                Console.WriteLine(y);
            }
            Console.Read();
        }
        static void SunIsShining(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] += 2;
        }

    }
}
