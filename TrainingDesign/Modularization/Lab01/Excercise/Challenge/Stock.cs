using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Challenge
{
    public class Stock
    {
        private static IDictionary<Product, int> stock = new Dictionary<Product, int>()
        {
            { Product.A, 10},
            { Product.B, 10},
            { Product.C, 10},
            { Product.D, 10},
        };

        public static bool IsAvailable(Product p, int amount)
        {

            if (!stock.ContainsKey(p))
            {
                return false;
            }
            else
            {
                return (stock[p] >= amount);
            }
        }

        public static bool ReserveForOrder(Product p, int amount)
        {

            if (!IsAvailable(p, amount))
            {
                return false;
            }
            else
            {
                stock[p] = stock[p] - amount;
                return true;
            }
        }

        public static void ReleaseFromOrder(Product p, int amount)
        {
            stock[p] = stock[p] + amount;
        }

    }
}
