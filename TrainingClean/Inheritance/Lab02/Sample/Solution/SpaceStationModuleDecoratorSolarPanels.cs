using Inheritance.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Solution
{
    public class SpaceStationModuleDecoratorSolarPanels : SpaceStationModuleDecorator
    {
        public readonly ChargeableResource BatteryToLoad;

        public SpaceStationModuleDecoratorSolarPanels(SpaceStationModule delegate2Wrap, ChargeableResource batteryToLoad)
            : base (delegate2Wrap)
        {
            BatteryToLoad = batteryToLoad;
        }

        /// <summary>
        /// this will not  call super, as instead heating up, we produce electricity
        /// </summary>
        public override void ReceiveSunshine()
        {
           BatteryToLoad.Charge(0.1d);
        }

    }
}
