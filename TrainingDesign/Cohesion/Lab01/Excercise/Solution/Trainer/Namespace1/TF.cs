using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TF
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TF).Name);
            TL.DoSomething();
        }
    }
}
