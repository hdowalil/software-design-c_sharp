using DependencyInversion.Lab02.Excercise.Challenge.N2;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Excercise.Challenge.N1
{
    class Class1
    {
        public static void Method1A()
        {
            Console.WriteLine("Logic of Method 1A");
            Method1B();
            Class2.Method2B();
        }

        public static void Method1B()
        {
            Console.WriteLine("Logic of Method 1B");
        }
    }
}
