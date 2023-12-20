using System.ComponentModel.Design;

namespace UserLogin
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        

        public static void Register()
        {
            Console.WriteLine("Enter your username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            password = Console.ReadLine();
            Console.WriteLine("Registeration Completed");
            Console.WriteLine("------------");
        }

        public static void Login()
        {
            Console.WriteLine("Enter your username:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login succesfull");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart the program");
                }
             
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart the program");
            }
        
        }

    } 
}
