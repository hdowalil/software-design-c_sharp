using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Excercise.Challenge
{
    class Comet : Debris
    {
        public Comet(long positionX, long positionY, long positionZ) :
            base(positionX, positionY, positionZ, 25000L)
        {
        }
    }
}
