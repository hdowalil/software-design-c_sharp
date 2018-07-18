using InformationHiding.Lab02.Sample.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Sample.Solution
{
    class Car
    {
        private Seatbelt seatbelt = new Seatbelt();
        private Engine engine = new Engine();

        public void SecureDriver()
        {
            seatbelt.BuckleUp();
        }

        public void Activate()
        {
            if (!seatbelt.Fastened)
            {
                throw new FastenSeatBeltsException();
            }
            engine.Start();
        }
    }
}
