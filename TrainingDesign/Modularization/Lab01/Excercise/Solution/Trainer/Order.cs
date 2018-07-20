using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Solution.Trainer
{
    public class Order
    {
        private IList<OrderPosition> positions = new List<OrderPosition>();

        private string _creditCard;
        public string CreditCard
        {

            set
            {
                if (!Shipment.IsValidPayment(value))
                {
                    throw new ArgumentException();
                }

                this._creditCard = value;
            }

            get
            {
                return this._creditCard;
            }
        }

        public bool Add(Product p, int amount)
        {

            if (!Stock.IsAvailable(p, amount))
            {
                return false;
            }

            Stock.ReserveForOrder(p, amount);

            positions.Add(new OrderPosition(p, amount));
            return true;
        }

        public void RemoveAt(int index)
        {
            Product p = GetProductAtPosition(index);
            int amount = GetAmountAtPosition(index);

            Stock.ReleaseFromOrder(p, amount);
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

        public void PlaceOrder(Customer customer)
        {
            Shipment.ParcelAndShip(CreditCard, this.positions, customer);
        }
    }
}
