using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Lab02.Excercise.Challenge
{
    class Shapes
    {
        public void Run()
        {

            char entry = ' ';

            while ('0' != entry)
            {
			
			    Console.WriteLine("Information about geometrical shapes");
			    Console.WriteLine("0 .. Quit");
			    Console.WriteLine("1 .. Circle");
			    Console.WriteLine("2 .. Square");

                entry = Console.ReadKey().KeyChar;

                if ('1' == entry)
                {
                    CirclePrintInfo();
                    CircleDraw();
                }
                else if ('2' == entry)
                {
                    SquareInfo();
                    SquareDraw();
                }

            }

        }

        public void CirclePrintInfo()
        {
		    Console.WriteLine("A circle is the set of all points in a plane that are at a given distance from a given point, the centre.");
        }

        public void CircleDraw()
        {
            Console.WriteLine(" ___");
            Console.WriteLine("/   \\");
            Console.WriteLine("\\___/");
        }

        public void SquareInfo()
        {
		    Console.WriteLine("A square is a regular quadrilateral, which means that it has four equal sides and four equal angles (90-degree angles).");
        }

        public void SquareDraw()
        {
		    Console.WriteLine(" ___");
		    Console.WriteLine("|   |");  
		    Console.WriteLine("|___|");
        }

        static void Main(string[] args)
        {
            (new Shapes()).Run();
        }
    }
}
