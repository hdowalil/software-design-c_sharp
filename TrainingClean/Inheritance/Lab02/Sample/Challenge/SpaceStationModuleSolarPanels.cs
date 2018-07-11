using Inheritance.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Challenge
{
    class SpaceStationModuleSolarPanels : SpaceStationModuleBasic
    {
        public readonly ChargeableResource batteryToLoad;

        public SpaceStationModuleSolarPanels(ChargeableResource batteryToLoad)
        {
            this.batteryToLoad = batteryToLoad;
        }

        /// <summary>
        /// this will not  call super, as instead heating up, we produce electricity
        /// </summary>
        public override void ReceiveSunshine()
        {
            this.batteryToLoad.Charge(0.1d);
        }

    }
}
