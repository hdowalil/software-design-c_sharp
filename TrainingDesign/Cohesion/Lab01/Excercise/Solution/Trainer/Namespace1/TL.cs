using Cohesion.Lab01.Excercise.Solution.Trainer.Namespace2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TL
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TL).Name);
            TM.DoSomething();
        }
    }
}
