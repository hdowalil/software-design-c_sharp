using DependencyInversion.Lab02.Excercise.Solution.Trainer.N2;
using DependencyInversion.Lab02.Excercise.Solution.Trainer.N3;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Excercise.Solution.Trainer.N1
{
    class Class1
    {
        public static void Method1A()
        {
            Console.WriteLine("Logic of Method 1A");
            Class3.Method1B();
            Class2.Method2B();
        }
    }
}
