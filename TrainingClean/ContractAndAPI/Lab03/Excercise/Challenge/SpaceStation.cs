using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab03.Excercise.Challenge
{
    class SpaceStation
    {
        public long PositionX { get; private set; }
        public long PositionY { get; private set; }
        public long PositionZ { get; private set; }

        public SpaceStation(long positionX, long positionY, long positionZ)
        {
            PositionX = positionX;
            PositionY = positionY;
            PositionZ = positionZ;
        }

        public void MoveLeft()
        {
        }

        public void MoveRight()
        {
        }

        public void MoveUp()
        {
        }

        public void MoveDown()
        {
        }

        public void MoveBackwards()
        {
        }

        public void MoveForward()
        {
        }

        public double Consume(double ampereHours)
        {
            return 0.0d;
        }

        public double Charge(double ampereHours)
        {
            return 0.0d;
        }

        public double EnergyLeftInAmpereHours()
        {
            return 0.0d;
        }

    }
}
