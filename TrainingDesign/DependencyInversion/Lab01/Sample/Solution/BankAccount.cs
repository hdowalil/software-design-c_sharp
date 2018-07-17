using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Sample.Solution
{
    // Declare a delegate type for processing a book:
    public delegate void BankAccountObserver(long amount);

    public class BankAccount
    {
        private long availableAmount;

        private IList<BankAccountObserver> observers = new List<BankAccountObserver>();

        public void RegisterObserver(BankAccountObserver newObserver)
        {
            observers.Add(newObserver);
        }

        public void RemoveObserver(BankAccountObserver observer2Remove)
        {
            observers.Remove(observer2Remove);
        }

        private void NotifyObservers()
        {
            foreach (BankAccountObserver concreteObserver in observers)
            {
                concreteObserver.Invoke(availableAmount);
            }
        }

        public void ReceiveMoney(long amount)
        {
            availableAmount += amount;
            NotifyObservers();
        }

        public void SpendMoney(long amount)
        {
            availableAmount -= amount;
            NotifyObservers();
        }
    }
}
