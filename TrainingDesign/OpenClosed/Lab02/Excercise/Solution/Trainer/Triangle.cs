using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab02.Excercise.Solution.Trainer
{
    class Triangle : IShape
    {
        public string Name()
        {
            return "Triangle";
        }

        public string Description()
        {
            return "A triangle is a polygon with three edges and three vertices.";
        }

        public void Draw()
        {
		    Console.WriteLine(" /\\");
		    Console.WriteLine("/__\\");
        }
    }
}
