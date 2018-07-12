using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CH
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CH).Name);
            CJ.DoSomething();
            CK.DoSomething();
        }
    }
}
