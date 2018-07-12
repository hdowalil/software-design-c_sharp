using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TB
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TB).Name);
            TD.DoSomething();
            TE.DoSomething();
        }
    }
}
