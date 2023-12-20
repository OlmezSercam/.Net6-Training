public class Lecture
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();
            


            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNull exception");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
            
            Console.ReadKey(); //amk kodu çalışmıyor 
            
              
        }
        
    }
}