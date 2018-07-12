using Cohesion.Lab01.Excercise.Solution.Trainer.Namespace2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace3
{
    public class TK
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TK).Name);
            TP.DoSomething();
        }
    }
}
