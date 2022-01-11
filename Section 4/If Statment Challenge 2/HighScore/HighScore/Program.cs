using System;

namespace HighScore
{
    class Program
    {
        static int highScore = 300;
        static string highScorePlayer = "Denis";
        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(350, "Neckers");

            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if (highScore < score)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"Highscore held by {playerName}");
            }
            else {
                Console.WriteLine($"Highscore {highScore} from {highScorePlayer} still stands!");
            }
        }
    }
}
