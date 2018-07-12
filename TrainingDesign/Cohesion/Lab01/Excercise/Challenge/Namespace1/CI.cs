using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CI
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CI).Name);
            CJ.DoSomething();
            CK.DoSomething();
        }
    }
}
