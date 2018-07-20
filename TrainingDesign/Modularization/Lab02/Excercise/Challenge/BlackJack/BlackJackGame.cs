using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modularization.Lab02.Excercise.Challenge.BlackJack
{
    /// <summary>
    /// Classic game of black jack. Player will draw at 16 and stay at 17.
    /// Black Jack(Jack, Queen or King and an Ace) is treated better than a sum of 21 any other way
    /// </summary>
    class BlackJackGame
    {
        private const int DealerDrawingLimit = 16;

        private const int WinningValue = 21;

        private const int InitialAmountOfMoney = 1000;

        // initial amount of money is 1000 bucks
        public bool GameRunning { get; private set; } = false;
        public bool GameWon { get; private set; } = false;
        public bool GameDraw { get; private set; } = false;

        public int Money { get; private set; } = InitialAmountOfMoney;

        private int bet = -1;
        private IList<Card> dealerCards = null;
        private IList<Card> playerCards = null;

        private Random rnd = new Random();

        public void StartNewGame(int bet4newGame)
        {
            AssertGameRunning(false);

            if (bet4newGame <= 0 || bet4newGame > Money)
            {
                throw new ArgumentException();
            }

            GameRunning = true;
            GameWon = false;
            GameDraw = false;

            bet = bet4newGame;

            dealerCards = new List<Card>();
            dealerCards.Add(RandomCard());

            playerCards = new List<Card>();
            playerCards.Add(RandomCard());
            playerCards.Add(RandomCard());

            CheckPlayersStatus();
        }

        /// <summary>
        /// I got enough cards, now let the dealer continue 
        /// </summary>
        /// <returns>will return amount of money (= score) that player has after this game</returns>
        public int Stand()
        {
            AssertGameRunning(true);

            FinishGame();

            return Money;
        }

        /// <summary>
        /// Gimme one more card!
        /// </summary>
        public void Hit()
        {
            AssertGameRunning(true);

            if (GetPlayerValueSum() >= WinningValue)
            {
                throw new InvalidOperationException();
            }

            playerCards.Add(RandomCard());

            CheckPlayersStatus();
        }

        public int GetPlayerValueSum()
        {

            return GetValueSum(playerCards);
        }

        public string GetVisibleDealerCardsAsString()
        {

            return GetCardsAsString(dealerCards);
        }

        public string GetPlayerCardsAsString()
        {

            return GetCardsAsString(playerCards);
        }

        private void CheckPlayersStatus()
        {

            int playerValueSum = GetPlayerValueSum();
            bool canPlayerContinue = playerValueSum < WinningValue;
            bool tooMuch = playerValueSum > WinningValue;

            if (!canPlayerContinue && !tooMuch)
            {
                FinishGame();
            }
            else if (tooMuch)
            {
                PlayerHasLost();
            }
        }

        private void AssertGameRunning(bool shouldBeRunning)
        {
            if (!GameRunning && shouldBeRunning)
            {
                throw new InvalidOperationException("game finished, start a new one calling startNewGame");
            }
            else if (GameRunning && !shouldBeRunning)
            {
                throw new InvalidOperationException("the game is still running!");
            }
        }

        private void PlayerHasDrawWithDealer()
        {
            GameRunning = false;
            GameDraw = true;
            GameWon = false;
            this.bet = -1;
        }

        private void PlayerHasLost()
        {
            Money -= this.bet;
            GameRunning = false;
            GameDraw = false;
            GameWon = false;
            this.bet = -1;
        }

        private void PlayerHasWon()
        {
            Money += this.bet;
            GameRunning = false;
            GameDraw = false;
            GameWon = true;
            this.bet = -1;
        }

        /*
         * Dealer will draw until is over limit
         */
        private void FinishGame()
        {

            int dealerValueSum = GetValueSum(dealerCards);
            while (dealerValueSum <= DealerDrawingLimit)
            {
                dealerCards.Add(RandomCard());
                dealerValueSum = GetValueSum(dealerCards);
            }

            if (IsBlackJack(dealerCards) && IsBlackJack(playerCards))
            {
                PlayerHasDrawWithDealer();
            }
            else if (IsBlackJack(dealerCards) && !IsBlackJack(playerCards))
            {
                PlayerHasLost();
            }
            else if (!IsBlackJack(dealerCards) && IsBlackJack(playerCards))
            {
                PlayerHasWon();
            }

            // No Black Jack!
            int dealerValue = GetValueSum(dealerCards);
            int playerValue = GetPlayerValueSum();

            if (dealerValue > WinningValue)
            {
                // dealer has too much, player not as game would be over already
                PlayerHasWon();
            }
            else if (dealerValue == playerValue)
            {
                PlayerHasDrawWithDealer();
            }
            else if (dealerValue > playerValue)
            {
                PlayerHasLost();
            }
            else
            {
                PlayerHasWon();
            }

        }

        private string GetCardsAsString(IList<Card> cards)
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Join(',',cards.Select(c => c.ToString())));

            result.Append(" / ");

            if (IsBlackJack(cards))
            {
                result.Append("Black Jack!");
            }
            else
            {
                result.Append(String.Format("Sum: {0}", GetValueSum(cards)));
            }

            return result.ToString();
        }

        private bool IsBlackJack(IList<Card> cards)
        {

            if (cards.Count == 2)
            {
                if (CardLogic.IsJackQueenOrKing(cards[0]) && cards[1] == Card.Ace)
                {
                    return true;
                }
                else if (CardLogic.IsJackQueenOrKing(cards[1]) && cards[0] == Card.Ace)
                {
                    return true;
                }
            }

            return false;
        }

        private int GetValueSum(IList<Card> cards)
        {

            // first sum up first values
            int sum = cards.Sum(c => CardLogic.GetValues(c)[0]);
            if (sum <= WinningValue)
            {
                return sum;
            }

            // if we are to high, we try other values, if any
            sum = cards.Sum(c =>
            {
                int[] values = CardLogic.GetValues(c);
                if (values.Length > 1)
                {
                    return values[1];
                } else
                {
                    return values[0];
                }
            });

            return sum;
        }

        private Card RandomCard()
        {
            Card[] allCards = Enum.GetValues(typeof(Card)).Cast<Card>().ToArray();

            int cardIndex = rnd.Next(allCards.Length);

            return allCards[cardIndex];
        }
    }
}
