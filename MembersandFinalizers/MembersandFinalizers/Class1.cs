using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersandFinalizers
{
    internal class Members
    {
        //private field
        private string memberName;
        private string jobTitle;
        private int salary ;

        //public field
        public int age;

        //property
        public string JobTitle
        {
            get
            {
                return JobTitle;
            }
            set
            {
                jobTitle = value;
            } 
        }

        //public method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}." +
                    " I'm {2} years old.", memberName, jobTitle, age);
            }
        }
        //private method
        private void SharingPrivateInfo()
        {
            
            Console.WriteLine("My salary is " + salary);
        }
        // constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }
        // Finalize - Destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members Object");
            Debug.Write("Destruction of Members object");
        }
    }
}
