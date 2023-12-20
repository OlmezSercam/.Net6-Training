namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young too party in the club");
                    break;
                case 25:
                    Console.WriteLine("Good to go");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
            Console.Read();

            if (age == 15)
            {
                Console.WriteLine("Too young too party in the club");
            }
            else if (25 == age)
            {
                Console.WriteLine("Good to go");
            } 
            else
            {
                Console.WriteLine("How old are you then?");
            }
            string username = "Sercan";

            switch (username)
            {
                case "Sercan";
                    Console.WriteLine("username is seco");
                    break; // kalanını yapmadım sıkıcı bir iki yer daha eklenebilir
            }

            
        }
    }
}
