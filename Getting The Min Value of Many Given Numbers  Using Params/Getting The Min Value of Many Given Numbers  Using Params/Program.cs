namespace Getting_The_Min_Value_of_Many_Given_Numbers__Using_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 0, 1, 5);
            Console.WriteLine("The minimum is {0}", min);
            Console.Read();
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number< min)
                    min = number;
            }
            return min;
            
        }
    }
}
