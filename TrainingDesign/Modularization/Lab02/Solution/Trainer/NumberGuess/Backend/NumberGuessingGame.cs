using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab02.Excercise.Solution.Trainer.NumberGuess.Backend
{
    class NumberGuessingGame
    {
        public bool GameOver { get; private set; } = false;
        private readonly int number2Guess;
        public readonly int From;
        public readonly int To;
        public int RoundsLeft { get; private set; }  = 25;

        /// <summary>
        /// the number that the player will have to guess, will be in the range from - to.
        /// that means, if you provide a range from=2 and to=3, the number 2 guess can be 2 or 3
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public NumberGuessingGame(int from, int to)
        {
            if (to <= from)
            {
                throw new ArgumentException();
            }

            From = from;
            To = to;

            Random rnd = new Random();
            this.number2Guess = from + rnd.Next((to - from) + 1);

        }

        public GuessResult Guess(int nr)
        {
            if (GameOver)
            {
                throw new InvalidOperationException();
            }

            if (RoundsLeft <= 0)
            {
                throw new InvalidOperationException();
            }

            RoundsLeft--;

            if (number2Guess == nr)
            {
                GameOver = true;
                return GuessResult.Bingo;
            }
            else if (nr > number2Guess)
            {
                return GuessResult.YourInputWasTooHigh;
            }
            else
            {
                return GuessResult.YourInputWasTooLow;
            }
        }

    }
}
