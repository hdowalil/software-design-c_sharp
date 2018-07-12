using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    public class CA
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(CA).Name);
            CB.DoSomething();
            CC.DoSomething();
            CD.DoSomething();
            Console.ReadKey();
        }
    }
}
