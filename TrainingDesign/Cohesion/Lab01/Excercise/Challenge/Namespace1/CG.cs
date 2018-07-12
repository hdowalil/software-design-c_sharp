using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CG
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CG).Name);
            CH.DoSomething();
            CI.DoSomething();
            CJ.DoSomething();
        }
    }
}
