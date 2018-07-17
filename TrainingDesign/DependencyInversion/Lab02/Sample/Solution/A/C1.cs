using DependencyInversion.Lab02.Sample.Solution.B;
using System;

namespace DependencyInversion.Lab02.Sample.Solution.A
{
    public class C1
    {
        private C2 c2 = new C2();
        private C3 c3 = new C3();
        private C5 c5 = new C5();

        public void DoC1()
        {
            Console.WriteLine("C1");
            c2.DoC2();
            c3.DoC3();
            c5.DoC5();
        }
    }
}
