namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;


            //unary operato
            num3 = -num1;
            bool isSunny = true;
            Console.WriteLine("Num3 is {0}", num3);


            
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment bitince
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0]", num++);
            Console.WriteLine("num is {0}", num);


            // pre increment önce
            ++num;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0]", ++num);


            // decrement satır bittikten sonra
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0]", num--);
            Console.WriteLine("num is {0}", num);

            // pre decrement satırdan önce
            --num;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0]", --num);
            Console.WriteLine("num is {0}", num);

            Console.ReadKey();
        }
    }
}
