using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Challenge
{
    abstract class Debris
    {
        public readonly long PositionX;
        public readonly long PositionY;
        public readonly long PositionZ;
        private long mass;

        protected Debris(long positionX, long positionY, long positionZ, long mass)
        {
            PositionX = positionX;
            PositionY = positionY;
            PositionZ = positionZ;
            this.mass = mass;
        }

        public long GetMass()
        {
            return this.mass;
        }

        protected void _SetMass(long newMass)
        {
            this.mass = newMass;
        }

        public virtual void SetMass(long newMass)
        {

            if (this.mass < newMass)
            {
                throw new ArgumentException("Space debris can only loose mass, not gain any");
            }

            _SetMass(newMass);
        }

    }
}
