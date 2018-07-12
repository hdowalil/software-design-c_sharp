using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace2
{
    class CM
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CM).Name);
            CN.DoSomething();
            CO.DoSomething();
            CP.DoSomething();
        }
    }
}
