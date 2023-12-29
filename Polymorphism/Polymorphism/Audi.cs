using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi : Car
    {
        public string Model { get; set; }
        private string brand = "Audi";
        public Audi(int hp, string color, string model):base(hp,color)
        {
            Model = model;
        }
        public new void ShowDetails(int hp, string color)
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " Color: " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired.", Model);
        }
    }
}
