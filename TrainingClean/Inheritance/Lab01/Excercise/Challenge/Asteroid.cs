using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Challenge
{
    class Asteroid : Debris
    {
        public Asteroid (long positionX, long positionY, long positionZ) : 
            base(positionX,positionY,positionZ, 100000L)
        {
        }

    }
}
