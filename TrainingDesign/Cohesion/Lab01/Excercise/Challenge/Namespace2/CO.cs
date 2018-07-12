using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace2
{
    class CO
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CO).Name);
            CP.DoSomething();
        }
    }
}
