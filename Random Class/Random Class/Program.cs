namespace Random_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();
            int numEyes;
            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }



            //Next içerisine yazdığımız değer 1,2 veya 3 olabilir bu çıktılara göre if ile istediğimizi yazdırıyoruz.
            Console.WriteLine("Please enter your question!");
            Console.ReadLine();
            Random yesNoMaybe = new Random();
            int answerNum;
            answerNum = yesNoMaybe.Next(1,4);
            if (answerNum == 1)
            {
                Console.WriteLine("Yes");
            }
            else if (answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.Read();

        }
    }
}
