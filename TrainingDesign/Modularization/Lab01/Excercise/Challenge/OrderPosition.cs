using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Challenge
{
    public class OrderPosition
    {
        public readonly Product Product;
        public readonly int Amount;

        public OrderPosition(Product p, int amount)
        {
            this.Product = p;
            this.Amount = amount;
        }

    }
}
