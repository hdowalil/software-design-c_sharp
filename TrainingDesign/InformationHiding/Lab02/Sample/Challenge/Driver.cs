using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Sample.Challenge
{
    class Driver
    {
        static void Main(string[] args)
        {
            Car wartburg = new Car();
            wartburg.Seatbelt.BuckleUp();
            wartburg.Engine.Start();

        }
    }
}
