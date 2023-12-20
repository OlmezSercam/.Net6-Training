using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
// Herhangi bir private string, int veyahut methodlar,
// public gibi başka yerlerden çağırılıp kullanılabilmesi için public
// olan methodların içinde kullanılıp ardından o methodlar çağırılır.
namespace ClassesandObjects
{
    internal class Car
    {
        // Member Variables
        private string _name; // private field used for storing data
        private int _hp = 5;
        private string _Color;

        //public int MaxSpeed = 350;

        // autonomous  public property auto değer ataması için yeni bir int tanımladık
        //public int MaxSpeed { get; set; }

        //Write-Only sadece set yapabiliyor get yapamıyor
        private int _maxSpeed;
        public int MaxSpeed 
        {  
            set
            {
                _maxSpeed = value;
            } 
        }

        //Read-Only yani sadece get yapabiliyor çünkü değer 10 a eşitlendi
        //public int MaxSpeed { get; } = 10;
        // public property hem set hem get yapıyor
        public string Name {  
            get { return _name; }
            set { 
                if (value == "")
                {
                   _name = "Hello World Defaul Name";
                }
                else
                {

                }
                _name = value;
                }
        }





        //Normalde methodlar constructorların alt tarafına konumlanır.                        
/*        public void setName(string name) 
        {
            if(name == "")
            {
                _name = "DefaultName";
            }
            else
            {
                _name = name;
            }
        }

        public void setHP(int HP)
        {
            if(HP < 0)
            {
                _hp = 0;
            }
            else if (HP > 500)
            {
                _hp = 0;
            }
            else
            {
                _hp = HP;
            }
        }
        public int GetHP()
        {
            return _hp;
        }
        
        
        
        public string GetName()
        {

            return _name;
        }


        // Default Constructor 
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _Color = "Red";
        }

        // Specific Constructor
        public Car(string name, int hp, string Color) 
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _Color = Color;
        }

        // Member Method
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        // Member Method
        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");

        }
*/
        // Member Method
        public void Details()
        {
            Console.WriteLine("The " + _Color + " car " + _name + " has " 
                + _hp + " hp");
        }
    }
}
