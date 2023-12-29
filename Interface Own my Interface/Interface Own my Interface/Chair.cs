using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Own_my_Interface
{
    internal class Chair : Furniture , IDestroyable
    {
        //Implemening the interface's property
        public string DestructionSound {  get; set; }
        public Chair(string color, string material) 
        {
            this.Color = color;
            this.Material= material;
            //initializing the interface's property with a value in the constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts"); 
        }
    }
}
