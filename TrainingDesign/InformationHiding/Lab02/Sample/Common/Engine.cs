using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Sample.Common
{
    class Engine
    {
        public bool Running { get; private set; } = false;

        public void Start()
        {
            Running = true;
        }

        public void Stop()
        {
            Running = false;
        }

    }
}
