using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Sample.Challenge
{
    class BankAccount
    {
        private long availableAmount;

        public void ReceiveMoney(long amount)
        {
            availableAmount += amount;
        }

        public void SpendMoney(long amount)
        {
            availableAmount -= amount;
            if (availableAmount < 100)
            {
                BankAccountWarning.Warn();
            }
        }
    }
}
