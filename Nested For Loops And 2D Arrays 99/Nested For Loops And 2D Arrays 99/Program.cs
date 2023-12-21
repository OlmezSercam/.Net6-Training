namespace Nested_For_Loops_And_2D_Arrays_99
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        
        
        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("This is 2D array printed using nested for loop");
            // outer for loop
            for (int i = 0; i <matrix.GetLength(0); i++ )
            {
                // i alttaki for loop tamamlanana kadar 0 kalacak.
                // tamamlanınca 1 olacak ve tekrar tamamlanana kadar 1 kalacak.
                //inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%2 !=0)
                    Console.WriteLine(matrix[i,j]+ "");
                } 
            }
            // diagonal olanları i=j olanları yazdırmak
            for (int i =0 ; i  <matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ( i ==  j)
                    {
                        matrix[i, j] = 1;
                        Console.WriteLine(matrix[i, j] + "");
                    }
                }
            }
            // 3 5 7 yazmak için
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j]);
            }
            Console.Read();
        }
        
    }
}
