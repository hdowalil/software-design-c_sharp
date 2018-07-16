using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab02.Excercise.Solution.Trainer
{
    class Circle : IShape
    {
        public string Name()
        {
            return "Circle";
        }

        public string Description()
        {
            return "A circle is the set of all points in a plane that are at a given distance from a given point, the centre.";
        }

        public void Draw()
        {
            Console.WriteLine(" ___");
            Console.WriteLine("/   \\");
            Console.WriteLine("\\___/");
        }

    }
}
