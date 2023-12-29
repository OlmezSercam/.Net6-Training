using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Own_my_Interface
{
    internal class Vehicle
    {
        //Properties
        public float Speed { get; set; }
        public string Color { get; set; }

        //Default Constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "Black";
        }

        //Simple Constructor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
