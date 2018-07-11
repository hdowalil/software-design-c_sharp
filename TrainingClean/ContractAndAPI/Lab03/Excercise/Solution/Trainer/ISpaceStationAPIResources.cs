using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab03.Excercise.Solution.Trainer
{
    interface ISpaceStationAPIResources
    {
        double Consume(double ampereHours);

        double Charge(double ampereHours);

        double EnergyLeftInAmpereHours();
    }
}
