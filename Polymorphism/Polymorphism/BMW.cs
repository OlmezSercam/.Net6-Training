using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal sealed class BMW : Car
        //Class seal edilirse inherit edilemez
    {
        public string Model { get; set; }
        private string brand = "BMW";
        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }
        public BMW()
        {

        }

        public new void ShowDetails(int hp, string color)
        {
            Console.WriteLine("Brand: "+brand+" HP: "+ HP+" Color: "+Color);
        }

        //Sealed
        //Seal edersek üzerine başka bir method override edilemez 
        
        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired.", Model);
        }
    }
}