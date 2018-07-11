using Inheritance.Lab02.Sample.Common;

namespace Inheritance.UnitTests
{
    class BatteryStub : ChargeableResource
    {
        public double AmpereHours = 0.0;

        public double Consume(double ampereHours)
        {
            AmpereHours -= ampereHours;
            return ampereHours;
        }

        public double Charge(double ampereHours)
        {
            AmpereHours += ampereHours;
            return ampereHours;
        }

    }
}
