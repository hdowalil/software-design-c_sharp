using Inheritance.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Solution
{
    public class SpaceStationModuleDecoratorLiving : SpaceStationModuleDecorator
    {
        public readonly int NumberOfBeds;
        public readonly int BedQuality;

        public SpaceStationModuleDecoratorLiving(SpaceStationModule delegate2Wrap, int numberOfBeds, int bedQuality)
            : base (delegate2Wrap)
        {
            NumberOfBeds = numberOfBeds;
            BedQuality = bedQuality;
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
