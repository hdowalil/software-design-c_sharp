using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace InformationHiding.Lab01.Sample.Solution
{
    class WeatherStation
    {
        private IDictionary<long, int> log = new Dictionary<long, int>();

        public void MeasureAndLog()
        {
            int temperatue = Measure();
            log.Add(DateTime.Now.Ticks, temperatue);
        }

        public int? GetMeasuredHistory(long ticks)
        {
            if (!log.TryGetValue(ticks, out int result))
            {
                return null;
            } else
            {
                return result;
            }
        }

        public IEnumerable<long> AllMeasuredHistoryLogs()
        {
            // the keyset is not immutable!
            // removing a key would remove it from our Dictionary!
            return log.Keys.ToImmutableArray();
        }

        private int Measure()
        {

            // now let´s assume this is a very complex thing to do:
            Random rnd = new Random();
            int temperature = rnd.Next(100);
            return temperature;
        }
    }
}
