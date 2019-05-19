using System;
namespace GuessingGame
{
    public class GuessingGame
    {
        public const int lowInt = 1;
        public const int upperInt = 11;

        public int Random { get; private set; }
        public int Tries { get; private set; }


        public GuessingGame()
        {
            Tries = 3;
            randomIntGenerator();
        }

        public bool Game(int num)
        {
            Tries--;
            if(num < lowInt || num > upperInt)
            {
                throw new ArgumentOutOfRangeException("num", "Enter number from 1 to 10");
            }

            if(num == Random)
            {
                return true;
            }
            return false;
        }

        private void randomIntGenerator()
        {
            Random generator = new Random();
            generator.Next(lowInt, upperInt);
        }
    }
}
