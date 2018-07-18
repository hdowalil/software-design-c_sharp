using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace InformationHiding.Lab02.Excercise.Common
{
    class SolarPanel
    {
        public readonly int NoOfCells;
        private Battery battery2Charge;

        public SolarPanel(int noOfcells, Battery battery2Charge)
        {
            Contract.Requires(battery2Charge != null);
            NoOfCells = noOfcells;
            this.battery2Charge = battery2Charge;
        }

        public void ReceiveHoursOfSunshine(int hours)
        {
            battery2Charge.Charge((double)NoOfCells * hours);
        }

    }
}
