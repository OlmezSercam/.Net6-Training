using System;
using System.Collections.Generic;
namespace INumerable_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a generic IEnumerable variable that takes any collection of type int
            // we will use this variable to store the collection that will get returned by the GetCollection() method
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1); // unknown collection numbersList oldu
            Console.WriteLine("This was a List<int>");

            // foreach number in collection we got back from GetCollection()
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            unknownCollection = GetCollection(5);
            Console.WriteLine("This was an Array of List");
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }


        }
        static IEnumerable<int> GetCollection(int option) 
        {
            // List ve Queue birer Generic collection
            // Get collection komutu ile bu collectionların base'i olan IEnumerable interfaceini iterate ediyoruz.
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1) 
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }


        }
    }
}
