﻿using Cohesion.Lab01.Excercise.Challenge.Namespace2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cohesion.Lab01.Excercise.Challenge.Namespace1
{
    class CE
    {
        public static void DoSomething()
        {
            Console.WriteLine(typeof(CE).Name);
            CL.DoSomething();
        }
    }
}
