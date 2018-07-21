using Modularization.Lab02.Excercise.Solution.Trainer.NumberGuess.Backend;
using Modularization.Lab02.Solution.Trainer.Portal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab02.Solution.Trainer.NumberGuess.UI
{
    class NumberGuessingConsole : IGameConsole
    {

        public string Name()
        {
            return "Number Guessing";
        }

        public int Run()
        {
            NumberGuessingGame game = new NumberGuessingGame(1, 99);

            String entry = "";

            while (!"0".Equals(entry) && !game.GameOver)
            {
			
			    Console.WriteLine("Guess my number that is somewhere from 1 to 99. You have {0} tries left!",game.RoundsLeft);
			    Console.WriteLine("Enter your next guess, or 0 to quit:");

                int nr = -1;
                do
                {
                    entry = Console.ReadLine();
                } while (!Int32.TryParse(entry, out nr));

                if (nr != 0)
                {
                    GuessResult result = game.Guess(nr);
                    if (GuessResult.Bingo == result)
                    {
					    Console.WriteLine("That´s it, congratulations!");
                    }
                    else if (GuessResult.YourInputWasTooHigh == result)
                    {
					    Console.WriteLine("The number you should guess is lower than that!");
                    }
                    else
                    {
					    Console.WriteLine("The number you should guess is higher than that!");
                    }

                }
            }

            if (game.GameOver)
            {
                return game.RoundsLeft;
            }
            else
            {
                // cancelled -> 0 points!
                return 0;
            }
        }
    }
}
