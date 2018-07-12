using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace2
{
    public class TN
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TN).Name);
            TO.DoSomething();
        }
    }
}
