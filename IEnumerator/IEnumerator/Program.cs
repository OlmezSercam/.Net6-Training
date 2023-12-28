using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerator
{
    internal class Program
    {
        // IEnumerabke bir interface türüdür.
        // IEnumerable <T>for generic collections (Recommended)
        // IEnumerabke for non generic collections

        // <summary>
        // IEnumerable contains a single method that you must implement when implementing this interface:
        // GetEnumerator(), which returns an IEnumerator<T> object.
        // The returned IEnumerator<T> provides the ability to iterate through the collection
        // by exposing a Current property that points at the objext we are currently at in the collection.
        // </summary>
        // <param name="args></param>

        // Class içine kurduğumuz Listeyi kullanabilmek için IEnumerator interface'ini iterate etmemiz gerekti
        
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach (Dog dog in shelter)
            {
                if(!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }
        public Dog(string name, bool ısNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = ısNaughtyDog;
        }

        //this method will print how many treats the dog received
        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} times", Name, numberofTreats);
        }
    }
    class DogShelter : IEnumerable<Dog> 
    {
        // list of type<Dog>
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
                {
                    new Dog("Casper", false),
                    new Dog("Mahir", true),
                    new Dog("Oreo", false),
                    new Dog("Pixel",false),
                };
                    
        }

        // bu IEnumaretorlar Class'a interface edildiğinde sorun gider yerine basıp çekiliyor
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            //implement etme yöntemi
            return dogs.GetEnumerator();
            
        }

        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}


