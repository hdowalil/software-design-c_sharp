using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Lab02.Sample.Common
{
    public class Astronaut
    {
        public string Name { get; private set; }
        public long FatigueInPercent { get; private set; }

        public Astronaut(string name)
        {
            Name = name;
            FatigueInPercent = 0;
        }

        public void DoSomething()
        {
            if (FatigueInPercent >= 100)
            {
                throw new InvalidOperationException("Astronaut with burnout!");
            }

            FatigueInPercent++;
        }

        public void Rest(int quality)
        {
            FatigueInPercent -= quality;
        }

    }
}
