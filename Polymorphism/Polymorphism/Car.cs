using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        // has a relationship
        protected CarIdnfo carIdInfo = new CarIdnfo();
        public void SetCarID(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned bt {1}",carIdInfo.IDNum,carIdInfo.Owner);
        }
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        public Car()
        {

        }

        public void ShowDetails(int hp, string color)
        {
            Console.WriteLine("HP: " + HP + " Color: " + Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}