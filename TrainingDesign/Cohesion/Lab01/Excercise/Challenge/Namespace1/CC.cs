using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CC
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CC).Name);
            CD.DoSomething();
            CF.DoSomething();
        }
    }
}
