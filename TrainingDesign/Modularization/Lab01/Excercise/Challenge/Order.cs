using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modularization.Lab01.Excercise.Challenge
{
    public class Order
    {
        private IList<OrderPosition> positions = new List<OrderPosition>();
        public string CreditCard { get; set; }

        public void Add(Product p, int amount)
        {
            positions.Add(new OrderPosition(p, amount));
        }

        public void RemoveAt(int index)
        {
            positions.RemoveAt(index);
        }

        public int Count()
        {
            return positions.Count;
        }

        public Product GetProductAtPosition(int index)
        {
            return positions[index].Product;
        }

        public int GetAmountAtPosition(int index)
        {
            return positions[index].Amount;
        }

        public int GetSum()
        {
            return positions.Sum(item => (int) item.Product * item.Amount);
        }
    }
}
