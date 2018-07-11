using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Solution.Trainer
{
    class Comet : SpaceDebris
    {
        public Comet(long positionX, long positionY, long positionZ) : 
            base(positionX,positionY,positionZ, 25000L)
        {
        }

    }
}
