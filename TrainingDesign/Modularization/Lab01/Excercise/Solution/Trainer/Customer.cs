using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Solution.Trainer
{
    public class Customer
    {
        private const string CreditCardNumber = "1234123456785678";

        public int CCLimitLeft { get; private set; } = 2000;

        private IDictionary<Product, int> myProducts = new Dictionary<Product, int>();

        public void PlaceAnOrder(params OrderPosition[] pos)
        {
            Order order = new Order();

            foreach (OrderPosition op in pos)
            {
                order.Add(op.Product, op.Amount);
            }
            order.CreditCard = CreditCardNumber;
            order.PlaceOrder(this);
        }

        public void ReceiveProducts(IDictionary<Product, int> products)
        {
            foreach (Product p in products.Keys)
            {
                myProducts.TryAdd(p, 0);
                myProducts[p] = myProducts[p] + products[p];
            }
        }

        public int GetAmountOfMyProducts(Product p)
        {
            myProducts.TryAdd(p, 0);
            return myProducts[p];
        }

        public void ChargeMyCC(int sum)
        {
            if (CCLimitLeft < sum)
            {
                throw new ArgumentException("CC Card Limit reached");
            }
            CCLimitLeft -= sum;
        }
    }
}
