using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Solution.Trainer
{
    class Spaceship : Debris
    {
        public Spaceship(long positionX, long positionY, long positionZ) :
            base(positionX, positionY, positionZ, 5000L)
        {
        }

        public override void SetMass(long newMass)
        {
            if (GetMass() != newMass)
            {
                throw new ArgumentException("A Spaceship cannot grow or lose weight");
            }
        }
    }
}
