﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CJ
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CJ).Name);
            CK.DoSomething();
        }
    }
}
