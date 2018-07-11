using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Common
{
    public interface SpaceStationModule
    {
        int GetTemperatureInCelsius();

        void ReceiveSunshine();

        void CoolDown(ChargeableResource battery);

        void RestAstronauts(params Astronaut[] astronauts);
    }
}
