using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Lab01.Sample.Challenge
{
    class BankAccountWarning
    {
        public static void Warn()
        {
            Console.Write("oops, we are below 100 bucks, go find a job ;-)");
        }
    }
}
