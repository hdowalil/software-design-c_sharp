using DependencyInversion.Lab02.Sample.Solution.B;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab02.Sample.Solution.A
{
    public class C3ToPackageBAdapter : WhatC4Needs
    {
        public int Called { get; private set; } = 0;
        private C3 c3 = new C3();

        public void WhatC4Needs()
        {
            Called++;
            c3.DoC3();
        }
    }
}
