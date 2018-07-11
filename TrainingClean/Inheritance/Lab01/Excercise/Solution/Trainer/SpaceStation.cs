using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Solution.Trainer
{
    class Spacestation : Debris
    {
        public Spacestation(long positionX, long positionY, long positionZ) :
            base(positionX, positionY, positionZ, 10000L)
        {
        }

        public override void SetMass(long newMass)
        {
            if (GetMass() > newMass)
            {
                throw new ArgumentException("A Spacestation cannot get smaller, it can only be extended by adding new modules");
            }

            base._SetMass(newMass);
        }
    }
}
