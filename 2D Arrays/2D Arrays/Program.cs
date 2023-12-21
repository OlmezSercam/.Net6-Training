

    namespace _2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;
            // 3D array
            int[,,] threeD; ;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3 }, //row 0
                {4, 5, 6 }, //row 1
                {7, 8, 9 }  //row 2
            };// 0  1  2
            Console.WriteLine("Central value is {0}", array2D[2,0]);
            string[,] array2DString = new string[3, 2]
            {
                {"one","two" },
                {"three", "four"},
                {"five", "six" }
            };
            array2DString[1, 1] = "Chicken";
            Console.WriteLine(array2DString[1,1]);

            //3D array
            string[,,] array3D = new string[,,]
            { //depth
                {  //height
                    {"000", "001" }, //length
                    {"010", "011" },
                    {"Hi there", "What's up" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one","Last entry" }
                }
            };
            Console.WriteLine("Central value is {0}", array3D[1,2,1]);
            Console.ReadKey();
        }
    }
}
