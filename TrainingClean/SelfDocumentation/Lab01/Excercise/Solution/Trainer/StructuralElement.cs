using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.Contracts;

namespace SelfDocumentation.Lab01.Excercise.Solution.Trainer
{
    public class StructuralElement
    {
        private const int YellowAlertIntegrity = 25;
        private const int RedAlertIntegrity = 10;
        private const int YellowAlertTemperature = 50;
        private const int RedAlertTemperature = 70;

        public int StructuralIntegrityPercent { get; set; }
        public int TemperatureInCelsius { get; set; }

        public StructuralElement(int structuralIntegrityPercent, int temperatureInCelsius)
        {
            StructuralIntegrityPercent = structuralIntegrityPercent;
            TemperatureInCelsius = temperatureInCelsius;
        }

        private static Alert CheckIntegrity4Alert(IEnumerable<StructuralElement> elements)
        {
            int minIntegrity = elements.Min(e => e.StructuralIntegrityPercent);

            if (minIntegrity < RedAlertIntegrity)
            {
                return Alert.Red;
            }
            else if (minIntegrity < YellowAlertIntegrity)
            {
                return Alert.Yellow;
            }
            else
            {
                return Alert.Green;
            }
        }

        private static Alert CheckTemperature4Alert(IEnumerable<StructuralElement> elements)
        {
            int maxTemperature = elements.Max(e => e.TemperatureInCelsius);

            if (maxTemperature > RedAlertTemperature)
            {
                return Alert.Red;
            }
            else if (maxTemperature > YellowAlertTemperature)
            {
                return Alert.Yellow;
            }
            else
            {
                return Alert.Green;
            }
        }

        public static Alert CheckElements4Alert(IEnumerable<StructuralElement> elements)
        {
            // A spacestation with 0 structural elements would not exist at all and therefore cannot be
            Contract.Requires(elements != null && elements.Count() > 0);

            return AlertExtensions.GetMaximumSeverity(
                    CheckIntegrity4Alert(elements),
                    CheckTemperature4Alert(elements));
        }

    }
}
