using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TE
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TE).Name);
            TL.DoSomething();
        }
    }
}
