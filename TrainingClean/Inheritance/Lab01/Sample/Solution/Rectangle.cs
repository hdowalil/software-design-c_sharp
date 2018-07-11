using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Sample.Solution
{
    class Rectangle : FourSidedFigure
    {
        public int Height;
        public int Width;

        public override int Area()
        {
            return base.CalculateAreaOfRectangularFourSidedFigure(Width, Height);
        }
    }
}
