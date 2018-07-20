using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Challenge
{
    public class Shipment
    {
        public static void ParcelAndShip(Order order, Customer customer)
        {
            IDictionary<Product, int> parcel = new Dictionary<Product, int>();

            for (int i = 0; i < order.Count(); i++)
            {
                Product product = order.GetProductAtPosition(i);
                parcel.TryAdd(product, 0);
                parcel[product] = parcel[product] + order.GetAmountAtPosition(i);
            }

            Console.WriteLine("Shipping: " + parcel);
            customer.ReceiveProducts(parcel);
        }
    }
}
