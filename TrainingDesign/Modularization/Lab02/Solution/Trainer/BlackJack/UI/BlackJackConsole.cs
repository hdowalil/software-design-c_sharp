using Modularization.Lab02.Excercise.Challenge.BlackJack;
using Modularization.Lab02.Solution.Trainer.Portal;
using System;

namespace Modularization.Lab02.Solution.Trainer.BlackJack.UI
{
    class BlackJackConsole : IGameConsole
    {

        public string Name()
        {
            return "Black Jack";
        }

        public int Run()
        {
            BlackJackGame game = new BlackJackGame();

            while (game.Money > 0)
            {

			    Console.WriteLine("How much do you want to bet? (Max: {0} or enter 0 to quit): ", game.Money);

                string entry = Console.ReadLine();

                if (Int32.TryParse(entry,out int betAmount))
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

    }
}
