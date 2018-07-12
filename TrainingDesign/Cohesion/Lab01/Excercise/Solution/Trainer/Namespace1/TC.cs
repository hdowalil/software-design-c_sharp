using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TC
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TC).Name);
            TD.DoSomething();
            TF.DoSomething();
        }
    }
}
