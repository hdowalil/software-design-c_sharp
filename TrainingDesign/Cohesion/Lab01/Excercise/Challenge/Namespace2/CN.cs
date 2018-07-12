using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace2
{
    class CN
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CN).Name);
            CO.DoSomething();
        }
    }
}
