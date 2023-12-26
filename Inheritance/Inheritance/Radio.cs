using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Child Class
    internal class Radio : ElectricalDevice
    {
        // bu inherit ettiği classla birlikte içereceği ortak bir constructor
        //base dediği inherit ettiği class burada electricaldevice class'ı
        public Radio (bool isOn, string brand):base(isOn, brand)
        {

        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first!");
            }
        }
            
    }
}
