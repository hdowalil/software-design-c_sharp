using Modularization.Lab02.Excercise.Challenge.BlackJack;
using Modularization.Lab02.Excercise.Challenge.NumberGuess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab02.Excercise.Challenge.UI
{
    class GamesConsole
    {
        private IDictionary<string, int> highScores = new Dictionary<string, int>();

        public void Play()
        {
            string entry = null;

            while (!"0".Equals(entry))
            {
                PrintHighScores();
			    Console.WriteLine("0 .. Quit");
                Console.WriteLine("Or fancy playing one of these great games:");
                Console.WriteLine("1 .. Black Jack");
                Console.WriteLine("2 .. Number Guessing");

                entry = Console.ReadLine();

                bool numeric = Int32.TryParse(entry, out int menuChoice);

                if (numeric) { 
                    if (menuChoice == 1)
                    {
                        int score = PlayBlackJack();
                        HighScore("Black Jack", score);
                    }
                    else if (menuChoice == 2)
                    {
                        int score = PlayNumberGuessing();
                        HighScore("Number Guessing", score);
                    }
                }

    			Console.WriteLine();
            }

        }

        private void PrintHighScores()
        {
            if (!(highScores.Count == 0))
            {
			    Console.WriteLine("Highscores:");
                foreach (KeyValuePair<string, int> highScore in highScores)
                {
                    Console.WriteLine("{0}: {1}", highScore.Key, highScore.Value);
                }
            }
        }

        private void HighScore(string game, int score)
        {
            if (highScores.ContainsKey(game))
            {
                if (score > highScores[game])
                {
                    highScores[game] = score;
                }
            }
            else
            {
                highScores[game] = score;
            }
        }

        private int PlayBlackJack()
        {

            BlackJackGame game = new BlackJackGame();

            while (game.Money > 0)
            {
			    Console.WriteLine("How much do you want to bet? (Max: {0} or enter 0 to quit): ", game.Money);

                String entry = Console.ReadLine();

                bool numeric = Int32.TryParse(entry, out int betAmount);

                if (numeric)
                {
                    if (betAmount <= 0)
                    {
                        // player wants to quit, the amount of money is the acheived score!
                        return game.Money;
                    }

                    if (betAmount <= game.Money)
                    {
                        PlayOneRoundOfBlackJack(game, betAmount);
                    }
                }
            }

            return game.Money;
        }

        private void PlayOneRoundOfBlackJack(BlackJackGame game, int bet)
        {
            game.StartNewGame(bet);

            while (game.GameRunning)
            {
			
			    Console.WriteLine("Dealer: {0}", game.GetVisibleDealerCardsAsString());
			    Console.WriteLine("Player: {0}", game.GetPlayerCardsAsString());
			
			    Console.WriteLine("One more card (Y/N)?");

                char entry = ' ';
                while ('Y' != entry && 'N' != entry)
                {
                    entry = Char.ToUpper(Console.ReadKey().KeyChar);
                }

                if ('Y' == entry)
                {
                    game.Hit();
                }
                else
                {
                    game.Stand();
                }
            }

            DisplayBlackJackResult(game);
        }

        private void DisplayBlackJackResult(BlackJackGame game)
        {
		    Console.WriteLine("Dealers Deck: {0}", game.GetVisibleDealerCardsAsString());
		    Console.WriteLine("Players Deck: {0}", game.GetPlayerCardsAsString());
            if (game.GameDraw)
            {
                Console.WriteLine("Game is a draw!");
            }
            else if (game.GameWon)
            {
                Console.WriteLine("You won this round!");
            }
            else
            {
			    Console.WriteLine("You lost this round!");
            }
		    Console.WriteLine("You have {0} left!", game.Money);
        }

        private int PlayNumberGuessing()
        {
            NumberGuessingGame game = new NumberGuessingGame(1, 99);

            String entry = "";

            while (!"0".Equals(entry) && !game.GameOver)
            {
			
			    Console.WriteLine("Guess my number that is somewhere from 1 to 99. You have %d tries left!");
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

        static void Main(string[] args)
        {
            GamesConsole console = new GamesConsole();
            console.Play();
        }

    }
}
