using System.ComponentModel.Design;

namespace Score__if_statement
{
    internal class Program
    {
        static int highscore = 300;
        static string highscoreplayer = "Sercan";
        
        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(315, "Michael");
            CheckHighScore(350, "Sercan");

            Console.Read();
        }

        public static void CheckHighScore (int score, string playername)
        {
            if (score > highscore)
            {
                highscore = score;
                highscoreplayer = playername;
                Console.WriteLine("New high score is " + score);
                Console.WriteLine("It is now held by " + playername);
            }
            else
            {
                Console.WriteLine("The old highscore could not be br" +
                    "oken. It is still " + highscore +" and held by the "+ highscoreplayer);
            }
        }   
        

    }

}
