using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modularization.Lab01.Excercise.Solution.Trainer
{
    public class Shipment
    {
        public static void ParcelAndShip(String creditCard, IList<OrderPosition> positions, Customer customer)
        {
            int sum = positions.Sum(item => (int)item.Product * item.Amount);

            Billing.ChargeCreditCard(creditCard, sum);

            IDictionary<Product, int> parcel = new Dictionary<Product, int>();

            for (int i = 0; i < positions.Count; i++)
            {
                Product product = positions[i].Product;
                parcel.TryAdd(product, 0);
                parcel[product] = parcel[product] + positions[i].Amount;
            }

            Console.WriteLine("Modular shipping: " + parcel);
            customer.ReceiveProducts(parcel);
        }

        public static bool IsValidPayment(String cc)
        {
            return Billing.IsValidCreditCard(cc);
        }

    }
}
