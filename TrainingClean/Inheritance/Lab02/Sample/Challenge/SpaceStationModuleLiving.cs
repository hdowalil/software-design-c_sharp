using Inheritance.Lab02.Sample.Common;

namespace Inheritance.Lab02.Sample.Challenge
{
    class SpaceStationModuleLiving : SpaceStationModuleBasic
    {
        public readonly int NumberOfBeds;
        public readonly int BedQuality;

        public SpaceStationModuleLiving(int numberOfBeds, int bedQuality)
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
