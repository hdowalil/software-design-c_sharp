using System;
using System.Diagnostics.Contracts;

namespace ContractAndAPI.Lab02.Excercise.Challenge
{
    class Battery
    {
        public double CapacityInAmpereHours { get; private set; }
        public double LevelOfAmpereHours { get; private set; }

        public Battery(double capacityInAmpereHours)
        {
            CapacityInAmpereHours = capacityInAmpereHours;
            // when battery is created, it will always be filled as well
            LevelOfAmpereHours = CapacityInAmpereHours;
        }

        public double Consume(double ampereHours)
        {
            Contract.Requires(ampereHours > 0.0);

            if (ampereHours > LevelOfAmpereHours)
            {
                double result = LevelOfAmpereHours;
                LevelOfAmpereHours = 0.0d;
                return result;
            }
            else
            {
               LevelOfAmpereHours -= ampereHours;
               return ampereHours;
            }
        }

        public double Charge(double ampereHours)
        {
            Contract.Requires(ampereHours > 0.0);

            if (LevelOfAmpereHours + ampereHours > CapacityInAmpereHours)
            {
                double result = CapacityInAmpereHours - LevelOfAmpereHours;
                LevelOfAmpereHours = CapacityInAmpereHours;
                return result;
            }
            else
            {
                LevelOfAmpereHours += ampereHours;
                return ampereHours;
            }
        }

        public static void Main(string[] args)
        {
            Battery battery = new Battery(1000d);

            double charged = battery.Charge(100.0d);
            Console.WriteLine("Should be 0.0: {0}", charged);
            Console.WriteLine("Should be 1000.0: {0}", battery.LevelOfAmpereHours);

            double consumed = battery.Consume(100.0d);
            Console.WriteLine("Should be 100.0: {0}", consumed);
            Console.WriteLine("Should be 900.0: {0}", battery.LevelOfAmpereHours);

            consumed = battery.Consume(910.0d);
            Console.WriteLine("Should be 900.0: {0}", consumed);
            Console.WriteLine("Should be 0.0: {0}", battery.LevelOfAmpereHours);

            charged = battery.Charge(100.0d);
            Console.WriteLine("Should be 100.0: {0}", charged);
            Console.WriteLine("Should be 100.0: {0}", battery.LevelOfAmpereHours);

            Console.ReadKey();
        }
    }
}
