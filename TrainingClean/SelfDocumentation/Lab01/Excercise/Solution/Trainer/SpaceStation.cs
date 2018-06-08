using System;
using System.Collections.Generic;

namespace SelfDocumentation.Lab01.Excercise.Solution.Trainer
{
    public class SpaceStation
    {
        private const long InitialLevelOfOxygen = 10000L;
        private const double InitialLevelOfAmpereHoursInABattery = 10000d;

        private const long YellowAlertOxygen = 1000L;
        private const long RedAlertOxygen = 100L;
        private const double YellowAlertBatteryAmpereHours = 1000d;
        private const double RedAlertBatteryAmpereHours = 100d;

        public readonly IList<StructuralElement> Elements = new List<StructuralElement>();
        public long Oxygen = InitialLevelOfOxygen;
        public double BatteryAmpereHours = InitialLevelOfAmpereHoursInABattery;

        public void logStatus()
        {
            Console.WriteLine(
                $"Number of Elements: {Elements.Count} / Oxygen: {Oxygen} / Battery: {BatteryAmpereHours}");
        }

        private Alert checkOxygen4Alert()
        {
            if (Oxygen < RedAlertOxygen)
            {
                return Alert.Red;
            }
            else if (Oxygen < YellowAlertOxygen)
            {
                return Alert.Yellow;
            }
            else
            {
                return Alert.Green;
            }
        }

        private Alert checkBattery4Alert()
        {
            if (BatteryAmpereHours < RedAlertBatteryAmpereHours)
            {
                return Alert.Red;
            }
            else if (BatteryAmpereHours < YellowAlertBatteryAmpereHours)
            {
                return Alert.Yellow;
            }
            else
            {
                return Alert.Green;
            }
        }

        public Alert check4Problem()
        {

            return AlertExtensions.getMaximumSeverity(
                    StructuralElement.checkElements4Alert(Elements),
                    checkOxygen4Alert(),
                    checkBattery4Alert());
        }
    }
}
