using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Sample.Solution
{
    class Driver
    {
        static void Main(string[] args)
        {
            Car tesla = new Car();
            tesla.SecureDriver();
            tesla.Activate();

        }
    }
}
