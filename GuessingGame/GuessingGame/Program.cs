using System;

namespace GuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GuessingGame guessingGame = new GuessingGame();

            Console.WriteLine("Guess number from {0} to {1}", GuessingGame.lowInt, GuessingGame.upperInt -1);
            bool gameOver = false;
            do
            {
                Console.WriteLine("Enter number:");
                int playerNumber = int.Parse(Console.ReadLine());
                try
                {
                    if (guessingGame.Game(playerNumber))
                    {
                        Console.WriteLine("You are guessed");
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid number: " + e.Message);
                }
                Console.WriteLine("Remaining tries: " + guessingGame.Tries + "\n");

                if (guessingGame.Tries <= 0)
                {
                    break;
                }
            } while (!gameOver);
            if(!gameOver)
            {
                Console.WriteLine("Game over");
            }

        }
    }
}
