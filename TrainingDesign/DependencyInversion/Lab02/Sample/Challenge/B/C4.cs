using DependencyInversion.Lab02.Sample.Challenge.A;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Sample.Challenge.B
{
    class C4
    {
        private C3 c3 = new C3();
        private C5 c5 = new C5();
        private C6 c6 = new C6();
        private C7 c7 = new C7();

        public void DoC4()
        {
            c3.DoC3();
            Console.WriteLine("C4");
            c5.DoC5();
            c6.DoC6();
            c7.DoC7();
        }
    }
}
