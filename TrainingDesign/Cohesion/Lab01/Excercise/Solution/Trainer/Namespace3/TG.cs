using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace3
{
    public class TG
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TG).Name);
            TH.DoSomething();
            TI.DoSomething();
            TJ.DoSomething();
        }
    }
}
