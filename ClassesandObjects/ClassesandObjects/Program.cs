using System;
namespace ClassesandObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();

            myCar.MaxSpeed = 180;
            Console.WriteLine("Maxspeed is " + 180);//burada önce isim vererek set işlemini gerçekleştirdik ardından consolewrite içerisinde get yaptık.
            
            //myCar.Name = "MyAudiA3";
            //myCar.Details();
            //myCar.setName("my best car");
            /*myCar.setHP(200);
            Console.WriteLine("My car's name is: " + myCar.GetName());
            Console.WriteLine("My car's hp is "+ myCar.GetHP());
            myCar.Details();
            Car Audi = new Car("Audi A4", 350 , "black");
            Audi.Drive();
            Audi.Details();

            Car Bmw = new Car("Bmw m5", 310, "white");
            Bmw.Drive();
            Bmw.Details();

            Console.WriteLine("Press 1 to stop the car");

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Audi.Stop();
                Bmw.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinitely");
            }*/
            
            
        }
    }
}
