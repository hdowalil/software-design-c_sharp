using Inheritance.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Solution
{
    public abstract class SpaceStationModuleDecorator : SpaceStationModule
    {
        public readonly SpaceStationModule Delegate;

        protected SpaceStationModuleDecorator(SpaceStationModule delegate2Wrap)
        {
            Delegate = delegate2Wrap;
        }

        public virtual int GetTemperatureInCelsius()
        {
            return Delegate.GetTemperatureInCelsius();
        }

        public virtual void ReceiveSunshine()
        {
            Delegate.ReceiveSunshine();
        }

        public virtual void CoolDown(ChargeableResource battery)
        {
            Delegate.CoolDown(battery);
        }

        public virtual void RestAstronauts(params Astronaut[] astronauts)
        {
            Delegate.RestAstronauts(astronauts);
        }

    }
}
