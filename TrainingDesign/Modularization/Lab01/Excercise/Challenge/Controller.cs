using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Challenge
{
    public class Controller
    {
        private Customer customer;
        private Order order;

        public Controller(Customer customer)
        {
            this.customer = customer;
            this.order = new Order();
        }

        public bool Add2Order(Product p, int amount)
        {

            if (!Stock.IsAvailable(p, amount))
            {
                return false;
            }

            Stock.ReserveForOrder(p, amount);
            order.Add(p, amount);
            return true;
        }

        public void RemoveFromOrder(int index)
        {

            Product p = GetProductAtPosition(index);
            int amount = GetAmountAtPosition(index);

            Stock.ReleaseFromOrder(p, amount);
            order.RemoveAt(index);
        }

        public int GetNumberOfOrderPositions()
        {
            return order.Count();
        }

        public void SetCreditCard(String creditCard)
        {

            if (!Billing.IsValidCreditCard(creditCard))
            {
                throw new ArgumentException();
            }

            order.CreditCard = creditCard;
        }

        public Product GetProductAtPosition(int index)
        {
            return order.GetProductAtPosition(index);
        }

        public int GetAmountAtPosition(int index)
        {
            return order.GetAmountAtPosition(index);
        }

        public void PlaceOrder()
        {

            Billing.ChargeCreditCard(order.CreditCard, order.GetSum());

            Shipment.ParcelAndShip(order, customer);
        }
    }
}
