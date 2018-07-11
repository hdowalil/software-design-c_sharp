using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Common
{
    public interface ChargeableResource
    {
        double Consume(double ampereHours);

        double Charge(double ampereHours);
    }
}
