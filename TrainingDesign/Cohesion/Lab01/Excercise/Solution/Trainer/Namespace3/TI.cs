using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace3
{
    public class TI
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TI).Name);
            TJ.DoSomething();
            TK.DoSomething();
        }
    }
}
