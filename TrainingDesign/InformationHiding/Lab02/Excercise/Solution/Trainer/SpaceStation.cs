using InformationHiding.Lab02.Excercise.Common;
using System.Collections.Generic;

namespace InformationHiding.Lab02.Excercise.Solution.Trainer
{
    class SpaceStation : ISpaceLaboratory
    {
        private IList<SolarPanel> solarPanels;
        private Battery battery;

        public SpaceStation(double batteryCapacity)
        {
            solarPanels = new List<SolarPanel>();
            battery = new Battery(batteryCapacity);
        }

        public int GetNoOfSolarPanels()
        {
            return solarPanels.Count;
        }

        public int GetNoOfCellsOfSolarPanel(int index)
        {
            return solarPanels[index].NoOfCells;
        }

        public void RemoveSolarPanel(int index)
        {
            solarPanels.RemoveAt(index);
        }

        public void AddSolarPanel(int noOfCells)
        {
            solarPanels.Add(new SolarPanel(noOfCells, battery));
        }

        public void HoursOfSunshine(int hours)
        {
            foreach (SolarPanel panel in solarPanels)
            {
                panel.ReceiveHoursOfSunshine(hours);
            }
        }

        public int RunExperiment(int input1, int input2)
        {
            Experiment ex = new Experiment(input1, input2);
            return ex.RunExperiment(this, battery);
        }
    }
}
