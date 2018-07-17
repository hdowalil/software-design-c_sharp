using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Sample.Solution
{
    public interface IBankAccountObserver
    {
        void AvailableAmountUpdated(long newAvailableAmount);
    }
}
