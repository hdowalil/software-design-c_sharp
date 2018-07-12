using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Sample.Challenge
{
    class Demo
    {
        public int Var1;
        public int Var2;

        public int MethodA()
        {
            return Var1 * 2;
        }

        public int MethodB()
        {
            return MethodA() * 3;
        }

        public int MethodC()
        {
            return Var2 * 4;
        }
    }
}
