using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Sample.Solution
{
    class Square : FourSidedFigure
    {
        public int SideLength;

        public override int Area()
        {
            return base.CalculateAreaOfRectangularFourSidedFigure(SideLength, SideLength);
        }

    }
}
