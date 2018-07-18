using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Sample.Common
{
    class Seatbelt
    {
        public bool Fastened { get; private set; }  = false;

        public void BuckleUp()
        {
            Fastened = true;
        }

        public void Undo()
        {
            Fastened = false;
        }

    }
}
