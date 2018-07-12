using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace2
{
    public class TM
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TM).Name);
            TN.DoSomething();
            TO.DoSomething();
            TP.DoSomething();
        }
    }
}
