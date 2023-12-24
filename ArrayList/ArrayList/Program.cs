using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring an Arraylist with undefined amount  of object
            ArrayList myArrayList = new ArrayList();
            // Declaring an ArrayList with defined amount of object
            ArrayList myArrasList2 = new ArrayList(100);
            List<int> myList = new List<int>();   

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // Delete element with specific value from the arraylist 
            myArrayList.Remove(13);
            myArrayList.Remove(13);

            // delete element at specific pozition (ilk satırı 25'i silecek)
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if  (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }

                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
    }
}
