using System;
using System.Diagnostics.Contracts;

namespace InformationHiding.Lab02.Excercise.Common
{
    class Battery
    {
        private double capacityInAmpereHours;
        private double levelOfAmpereHours = 0.0d;

        public Battery(double capacityInAmpereHours)
        {
            this.capacityInAmpereHours = capacityInAmpereHours;
        }

        [ContractInvariantMethod]
        public void ObjectInvariant()
        {
            Contract.Invariant(this.levelOfAmpereHours > 0.0d);
            Contract.Invariant(this.capacityInAmpereHours > 0.0d);
            Contract.Invariant(this.levelOfAmpereHours <= this.capacityInAmpereHours);
        }

        public double Use(double ampereHours)
        {
            if (ampereHours > this.levelOfAmpereHours)
            {
                throw new Exception("Out of Electricity");
            }

            this.levelOfAmpereHours -= ampereHours;

            Contract.Ensures(this.levelOfAmpereHours >= 0.0d);

            return this.levelOfAmpereHours;
        }

        public double Charge(double ampereHours)
        {
            Contract.Requires(ampereHours > 0);

            double result = this.levelOfAmpereHours + ampereHours;

            if (result > capacityInAmpereHours)
            {
                // charge to the maximum, more is not possible
                this.levelOfAmpereHours = capacityInAmpereHours;
            }
            else
            {
                this.levelOfAmpereHours += ampereHours;
            }

            return this.levelOfAmpereHours;
        }

        public double EnergyLeftInAmpereHours()
        {
            return levelOfAmpereHours;
        }
    }
}
