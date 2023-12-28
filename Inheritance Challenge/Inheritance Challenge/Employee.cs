using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    internal class Employee
    {
        //Properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        //Constructor
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        //Default Constructor
        public Employee() 
        {
            Name = "Ölmez";
            FirstName = "Sercan";
            Salary = 0;
        }

        //Method
        public void Work()
        {
            Console.WriteLine("I'm working!");
        }
        
        public void Pause()
        {
            Console.WriteLine("I'm having a break.");
        }
    }
}
