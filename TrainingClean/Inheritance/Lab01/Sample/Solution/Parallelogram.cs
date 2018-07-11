using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Sample.Solution
{
    class Parallelogram : FourSidedFigure
    {
        public int A;
        public int B;
        public int HA;

        public override int Area()
        {
            return base.CalculateAreaOfRectangularFourSidedFigure(A, HA);
        }

    }
}
