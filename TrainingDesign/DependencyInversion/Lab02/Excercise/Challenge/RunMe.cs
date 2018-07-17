using DependencyInversion.Lab02.Excercise.Challenge.N1;
using DependencyInversion.Lab02.Excercise.Challenge.N2;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Excercise.Challenge
{
    class RunMe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Should be: 1A, 1B, 2B, 2A, 1B");

            Class1.Method1A();

            Class2.Method2A();

            Console.ReadKey();
        }
    }
}
