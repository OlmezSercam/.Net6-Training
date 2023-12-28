using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    internal class Boss : Employee
        
    {
        //Property
        public string CompanyCar {  get; set; }
        // Constructor
        public Boss(string companyCar, string name, string firstName,
            int salary):base(name,firstName,salary)
        {
            this.CompanyCar = companyCar;
        }
        // Method
        public void Lead()
        {
            Console.WriteLine("I'm boss! My name is {0}", FirstName);
        }
    }
}
