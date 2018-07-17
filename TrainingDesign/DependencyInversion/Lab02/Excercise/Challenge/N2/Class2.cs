using System;
using DependencyInversion.Lab02.Excercise.Challenge.N1;

namespace DependencyInversion.Lab02.Excercise.Challenge.N2
{
    class Class2
    {
        public static void Method2A()
        {
            Console.WriteLine("Logic of Method 2A");
            Class1.Method1B();
        }

        public static void Method2B()
        {
            Console.WriteLine("Logic of Method 2B");
        }
    }
}
