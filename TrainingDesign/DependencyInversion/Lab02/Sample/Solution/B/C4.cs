using DependencyInversion.Lab02.Sample.Solution.A;
using System;
using Microsoft;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Sample.Solution.B
{
    public class C4
    {
        public WhatC4Needs WhatINeed { get; set; }
        private C5 c5 = new C5();
        private C6 c6 = new C6();
        private C7 c7 = new C7();

        public C4(WhatC4Needs whatINeed)
        {
            WhatINeed = whatINeed;
        }

        public void DoC4()
        {
            WhatINeed.WhatC4Needs();
            Console.WriteLine("C4");
            c5.DoC5();
            c6.DoC6();
            c7.DoC7();
        }
    }
}
