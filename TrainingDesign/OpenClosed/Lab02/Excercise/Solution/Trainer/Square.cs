using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab02.Excercise.Solution.Trainer
{
    class Square : IShape
    {
        public string Name()
        {
            return "Square";
        }

        public string Description()
        {
            return "A square is a regular quadrilateral, which means that it has four equal sides and four equal angles (90-degree angles).";
        }

        public void Draw()
        {
		    Console.WriteLine(" ___");
		    Console.WriteLine("|   |");
		    Console.WriteLine("|___|");
        }

    }
}
