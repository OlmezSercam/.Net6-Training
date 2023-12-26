using System;
using System.Collections.Generic;
namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stackte Veri en üste eklenir veya en üstten çıkarılır aşağıya erişim yoktur.
            //undo butonu veya tarayıcılardaki geri gitme butonları stack
            //Queue veri en arkadan girer ve en önden çıkar sırada beklemek gibi

            //defining a new stack 
            Stack<int> stack = new Stack<int>();

            // add elements to the stack using the Push()
            stack.Push(1);
            stack.Push(137);

            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());


            //removing the element Pop()
            stack.Pop();

            // silinecek elementin stacklenmesi
            int myStackItem = stack.Pop();


            while (stack.Count > 0)
            {
                Console.WriteLine("The Top Value {0} was removed from the stack", stack.Pop);
                Console.WriteLine("Current stack count is {0}", stack.Count);
            }
            
            // array içindeki sayıları stack içerisine yazma
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 }; //array
            // defining a new stack
            Stack<int> myStack = new Stack<int>();
            Console.WriteLine("the numbers in the array are: ");
            foreach (int number in numbers)
            {
                // print it
                Console.WriteLine(number + " ");
                //push it into our stack(add)
                myStack.Push(number);
            }

            // array içindeki sayıları stack içerisinden çıkarırken tersten yazmak
            Console.WriteLine(" ");
            Console.WriteLine("the numbers in reverse: ");

            while (myStack.Count>0)
            {
                int number = myStack.Pop();
                Console.Write(number + " ");
            }  
        }
    }
}
