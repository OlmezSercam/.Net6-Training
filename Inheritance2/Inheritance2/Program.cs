namespace Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Dog = new Dog("Mahir", 23);
            Console.WriteLine($"{Dog.Name} is {Dog.Age} years old");
            Dog.MakeSound();
            Dog.Play();
            Dog.Eat();
        }
    }
}
