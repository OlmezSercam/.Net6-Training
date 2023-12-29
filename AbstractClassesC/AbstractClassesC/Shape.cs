using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    //Abstract classların içerisine üye oluşturulamaz fakat
    // içinde bulunan methodlar ve propertyler kullanılabilir.
    abstract class Shape
    {
        public string Name { get; set; }
        public  virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }
        public abstract double Volume();
    }
}
