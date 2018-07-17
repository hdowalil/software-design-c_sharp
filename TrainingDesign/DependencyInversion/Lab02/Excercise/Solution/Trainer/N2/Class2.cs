using System;
using DependencyInversion.Lab02.Excercise.Solution.Trainer.N3;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Excercise.Solution.Trainer.N2
{
    class Class2
    {
        public static void Method2A()
        {
            Console.WriteLine("Logic of Method 2A");
            Class3.Method1B();
        }

        public static void Method2B()
        {
            Console.WriteLine("Logic of Method 2B");
        }
    }
}
