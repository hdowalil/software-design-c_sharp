using System;
using System.Collections.Generic;
using System.Text;

namespace Modularization.Lab01.Excercise.Solution.Trainer
{
    public class Billing
    {
        public static bool IsValidCreditCard(string cc)
        {
            return cc != null && cc.Length == 16;
        }

        public static void ChargeCreditCard(String cc, int sum)
        {

            if (!IsValidCreditCard(cc))
            {
                throw new ArgumentException();
            }

            Console.WriteLine("Charging CC {0} with {1}", cc, sum);
        }
    }
}
