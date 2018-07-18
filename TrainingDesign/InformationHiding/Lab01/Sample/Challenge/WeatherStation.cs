using System;
using System.Collections.Generic;

namespace InformationHiding.Lab01.Sample.Challenge
{
    class WeatherStation : Dictionary<long, int>
    {
        public int Measure()
        {

            // now let´s assume this is a very complex thing to do:
            Random rnd = new Random();
            int temperature = rnd.Next(100);

            return temperature;
        }

        public int MeasureAndLog()
        {

            int temperature = Measure();
            base.Add(DateTime.Now.Ticks, temperature);
            return temperature;
        }

    }
}
