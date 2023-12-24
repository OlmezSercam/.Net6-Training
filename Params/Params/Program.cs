namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "KralKatlinin";
            
            
            ParamsMethod("This", " is ", "a ", "fucking", "endless", " string", " I", " learn ", "params ", "which");
            ParamsMethod2("\na",3, 7.14,'!');
            ParamsMethod2(price,pi,at,book);
        }// param methodu kaç tane olduğunu söylemeden hepsini yazdırır içinde değişiklik kolaylıkla yapılabilir.


        public static void ParamsMethod(params string[] sentence)
        {
            for (int i=0; i<sentence.Length; i++)
            {
                Console.Write(sentence[i]+ " ");
            }
        }

        // param methodunda value type string int float tarzı karışık olabilir 
        // normalde methodlarda int string vs diye ayırman gerekiyor 
        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.ReadKey();
        }
    }
}
