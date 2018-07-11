using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Solution.Trainer
{
    abstract class SpaceDebris : Debris
    {
        protected SpaceDebris(long positionX, long positionY, long positionZ, long mass) :
            base(positionX, positionY, positionZ, mass)
        {
        }

        public override void SetMass(long newMass)
        {
            if (GetMass() < newMass)
            {
                throw new ArgumentException("Space debris can only loose mass, not gain any");
            }

            _SetMass(newMass);
        }

    }
}
