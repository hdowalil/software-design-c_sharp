using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Solution.Trainer.Namespace1
{
    public class TA
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(TA).Name);
            TB.DoSomething();
            TC.DoSomething();
            TD.DoSomething();
            Console.ReadKey();
        }
    }
}
