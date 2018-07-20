using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab02.Excercise.Challenge.BlackJack
{
    enum Card
    {
        C1 = 1, 
        C2 = 2, 
        C3 = 3, 
        C4 = 4,
        C5 = 5,
        C6 = 6,
        C7 = 7,
        C8 = 8,
        C9 = 9,
        C10 = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    class CardLogic
    {
        public static bool IsJackQueenOrKing(Card input)
        {
            return
                    Card.Jack == input ||
                    Card.Queen == input ||
                    Card.King == input;
        }

        public static int[] GetValues(Card input)
        {
            switch (input)
            {
                case Card.C1: return new int[] { 1 };
                case Card.C2: return new int[] { 2 };
                case Card.C3: return new int[] { 3 };
                case Card.C4: return new int[] { 4 };
                case Card.C5: return new int[] { 5 };
                case Card.C6: return new int[] { 6 };
                case Card.C7: return new int[] { 7 };
                case Card.C8: return new int[] { 8 };
                case Card.C9: return new int[] { 9 };
                case Card.C10: return new int[] { 10 };
                case Card.Jack: return new int[] { 10 };
                case Card.Queen: return new int[] { 10 };
                case Card.King: return new int[] { 10 };
                case Card.Ace: return new int[] { 11, 1 };
            }

            throw new InvalidOperationException();
        }

    }
}
