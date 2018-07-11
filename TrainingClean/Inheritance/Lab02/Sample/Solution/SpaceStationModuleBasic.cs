using Inheritance.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Solution
{
    public class SpaceStationModuleBasic : SpaceStationModule
    {
        private const long TemperatureTooHigh = 80;

        private int temperatureInCelsius = 20;

        public void CoolDown(ChargeableResource battery)
        {
            this.temperatureInCelsius -= 5;
        }

        public int GetTemperatureInCelsius()
        {
            return temperatureInCelsius;
        }

        public virtual void ReceiveSunshine()
        {
            if (temperatureInCelsius > TemperatureTooHigh)
            {
                throw new InvalidOperationException("This module got too hot!");
            }

            temperatureInCelsius += 1;
        }

        public virtual void RestAstronauts(params Astronaut[] astronauts)
        {
            foreach (Astronaut astronaut in astronauts)
            {
                astronaut.Rest(1);
            }
        }
    }
}
