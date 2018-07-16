using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenClosed.Lab02.Excercise.Solution.Trainer
{
    class AllShapesConsole
    {

        private IEnumerable<Type> PlugIns (Type serviceInterface)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => !p.IsAbstract && !p.IsInterface && serviceInterface.IsAssignableFrom(p));
        }

        public void Run()
        {
            IEnumerable<Type> shapeTypes = PlugIns(typeof(IShape));
            IList<IShape> shapes = shapeTypes.Select(st => (IShape)Activator.CreateInstance(st)).ToList();

            int menuChoice = -1;
            while (menuChoice != 0)
            {
			
			    Console.WriteLine("Information about geometrical shapes");
			    Console.WriteLine("0 .. Quit");
                for (int i = 0; i < shapes.Count(); i++)
                {
                    int menu = i + 1;
                    Console.WriteLine($"{menu} .. {shapes[i].Name()}");
                }

                if (Int32.TryParse(Console.ReadLine(), out menuChoice))
                {
                    if (menuChoice <= shapes.Count() && menuChoice > 0)
                    {
                        int indexOfShapeInList = menuChoice - 1;
                        Console.WriteLine(shapes[indexOfShapeInList].Description());
                        shapes[indexOfShapeInList].Draw();
                    }
                }

            }

        }

        static void Main(string[] args)
        {
            (new AllShapesConsole()).Run();
        }
    }
}
