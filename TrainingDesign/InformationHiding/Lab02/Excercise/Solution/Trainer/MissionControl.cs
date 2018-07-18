using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Excercise.Solution.Trainer
{
    class MissionControl
    {
        static void Main(string[] args)
        {
            SpaceStation station = new SpaceStation(5000d);
            station.AddSolarPanel(50);
            station.AddSolarPanel(50);
            station.HoursOfSunshine(1);

            Console.WriteLine("The meaning of life: {0}", station.RunExperiment(5311, 100));
            Console.ReadKey();
        }
    }
}
