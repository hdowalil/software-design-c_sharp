using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab01.Sample.Solution
{
    abstract class FourSidedFigure
    {
        public abstract int Area();

        protected int CalculateAreaOfRectangularFourSidedFigure(int width, int height)
        {
            return width * height;
        }
    }
}
