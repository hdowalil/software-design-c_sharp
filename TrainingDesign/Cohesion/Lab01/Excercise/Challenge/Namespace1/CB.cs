using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CB
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CB).Name);
            CD.DoSomething();
            CE.DoSomething();
        }
    }
}
