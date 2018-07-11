using Inheritance.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Challenge
{
    class SpaceStationModuleLivingWithSolarPanels : SpaceStationModuleBasic
    {
        public readonly int NumberOfBeds;
        public readonly int BedQuality;
        public readonly ChargeableResource batteryToLoad;

        public SpaceStationModuleLivingWithSolarPanels(int numberOfBeds, int bedQuality, ChargeableResource batteryToLoad)
        {
            NumberOfBeds = numberOfBeds;
            BedQuality = bedQuality;
            this.batteryToLoad = batteryToLoad;
        }

        /// <summary>
        /// this will not  call super, as instead heating up, we produce electricity
        /// </summary>
        public override void ReceiveSunshine()
        {
            this.batteryToLoad.Charge(0.1d);
        }


        public override void RestAstronauts(params Astronaut[] astronauts)
        {

            for (int i = 0; i < astronauts.Length; i++)
            {
                {
                    if (i >= NumberOfBeds)
                    {
                        // no bed left, has to rest standing in the closet
                        astronauts[i].Rest(1);
                    }
                    else
                    {
                        astronauts[i].Rest(BedQuality);
                    }
                }
            }

        }


    }
}
