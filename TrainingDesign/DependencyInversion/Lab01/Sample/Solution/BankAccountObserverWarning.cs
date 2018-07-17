using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Sample.Solution
{
    public class BankAccountObserverWarning
    {
        public bool Warning { get; private set; } = false;

        public void AvailableAmountUpdated(long newAvailableAmount)
        {
            Warning = (newAvailableAmount < 100);

            if (Warning)
            {
                Console.Write("oops, we are below 100 bucks, go find a job ;-)");
            }
        }
    }
}
