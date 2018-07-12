using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Sample.Solution
{
    class Demo1
    {
        public int Var1;

        public int MethodA()
        {
            return Var1 * 2;
        }

        public int MethodB()
        {
            return MethodA() * 3;
        }
    }
}
