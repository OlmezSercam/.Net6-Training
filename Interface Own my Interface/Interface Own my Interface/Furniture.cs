using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Own_my_Interface
{
    internal class Furniture
    {
        //properties
        public string Color { get; set; }
        public string Material { get; set; }

        //Default Constructor
        public Furniture() 
        {
            Color = "White";
            Material = "Wood";
        }

        //Simple Constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
