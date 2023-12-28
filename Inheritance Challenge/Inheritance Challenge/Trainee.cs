using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{

    internal class Trainee : Employee
    {
        // Property
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        // Constructor
        public Trainee(int workingHours, int schoolHours, string name, string firstName,
            int salary):base(name,firstName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        // Method
        public void Learn()
        {
            Console.WriteLine("I'm learning.");
        }
        public void Work()
        {
            Console.WriteLine("I work for {0} hours",WorkingHours);
        }
    }
}
