using System.Net.Mail;
using System.Numerics;

namespace if_else_statements
{
    internal class uceYediyebolme
    {
        static int highScore = 150;
        static string highScorePlayer = "Sercan";
        static string highScoreOwners = "";
        static void Main(string[] args)
        {
            CheckHighScore(140,"Mert", "Sercan");
            CheckHighScore(150,"Ercan", "Sercan");
            CheckHighScore(140, "Sercan", "Sercan");
            CheckHighScore(201, "Eren", "Sercan");
            Console.Read();

        }
        public static void CheckHighScore(int score, string playerName, string highScoreOwners)
        {
            if (highScore < score)
            {
                highScore = score;
                highScorePlayer = playerName;
                
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else if (highScore == score)
            {
                highScore = score;
                highScorePlayer = playerName;
                string playerName2 = highScoreOwners;

                Console.WriteLine("Score is equal to highscore " + score +
                " there are multiple highscorers: " + playerName+ " and " + playerName2 );
                
            }
            else
            {
                Console.WriteLine("The old highscore of " + highScore +
                    " could not be broken and is still held by " + highScorePlayer )
;            }
        }
    }
}
