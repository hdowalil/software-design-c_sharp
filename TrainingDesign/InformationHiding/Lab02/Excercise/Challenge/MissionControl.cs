using InformationHiding.Lab02.Excercise.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Excercise.Challenge
{
    class MissionControl
    {
        static void Main(string[] args)
        {
            SpaceStation station = new SpaceStation();

            station.Battery = new Battery(5000d);
            station.SolarPanels = new List<SolarPanel>();
            station.SolarPanels.Add(new SolarPanel(50, station.Battery));
            station.SolarPanels.Add(new SolarPanel(50, station.Battery));

            foreach (SolarPanel panel in station.SolarPanels) {
                panel.ReceiveHoursOfSunshine(1);
            }

            Experiment theMeaningOfLifeAndEverything = new Experiment(5311, 100);
            int exResult = theMeaningOfLifeAndEverything.RunExperiment(station, station.Battery);
            Console.WriteLine("Experiment Result: {0}", exResult);
            Console.ReadKey();
        }
    }
}
