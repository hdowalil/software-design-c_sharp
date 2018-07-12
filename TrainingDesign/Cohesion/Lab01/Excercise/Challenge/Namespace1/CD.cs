using Cohesion.Lab01.Excercise.Challenge.Namespace2;
using System;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CD
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CD).Name);
            CF.DoSomething();
            CL.DoSomething();
        }
    }
}
