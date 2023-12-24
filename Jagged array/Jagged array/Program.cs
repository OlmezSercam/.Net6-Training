namespace Jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArrays = new int[3][];
            
            jaggedArrays[0] = new int[5];
            jaggedArrays[1] = new int[3];
            jaggedArrays[2] = new int[2];

            jaggedArrays[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArrays[1] = new int[] { 1, 2, 3 };
            jaggedArrays[2] = new int[] { 13, 25 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2,3,5,7,11},
                new int[] {1,2,3}
            };
            Console.WriteLine("The Value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("ELEMENT {0}",i);
                for (int j= 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("Element {0}", jaggedArray2[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
