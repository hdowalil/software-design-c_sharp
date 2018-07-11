using System;
using ContractAndAPI.Lab02.Excercise.Solution.Trainer;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab03.Excercise.Solution.Trainer
{
    class SpaceStation : ISpaceStationAPINavigation, ISpaceStationAPIResources
    {
        public long PositionX { get; private set; }
        public long PositionY { get; private set; }
        public long PositionZ { get; private set; }
        private readonly Battery battery;

        public SpaceStation(long positionX, long positionY, long positionZ, double batteryCapacity)
        {
            PositionX = positionX;
            PositionY = positionY;
            PositionZ = positionZ;
            battery = new Battery(batteryCapacity);
        }

        public void MoveLeft()
        {
            PositionX--;
        }

        public void MoveRight()
        {
            PositionX++;
        }

        public void MoveUp()
        {
            PositionY++;
        }

        public void MoveDown()
        {
            PositionY--;
        }

        public void MoveBackwards()
        {
            PositionZ--;
        }

        public void MoveForward()
        {
            PositionZ++;
        }

        public double Consume(double ampereHours)
        {
            return battery.Consume(ampereHours);
        }

        public double Charge(double ampereHours)
        {
            return battery.Consume(ampereHours);
        }

        public double EnergyLeftInAmpereHours()
        {
            return battery.LevelOfAmpereHours;
        }



    }
}
