using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TD
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(TD).Name);
            TF.DoSomething();
            TL.DoSomething();
        }
    }
}
