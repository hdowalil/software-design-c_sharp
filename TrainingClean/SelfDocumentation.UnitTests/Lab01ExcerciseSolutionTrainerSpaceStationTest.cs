using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelfDocumentation.Lab01.Excercise.Solution.Trainer;

namespace SelfDocumentation.UnitTests
{
    [TestClass]
    public class Lab01ExcerciseSolutionTrainerSpaceStationTest
    {
        [DataRow("90,20;98,22", 2000, 2000.0, Alert.Green)]

        [DataRow("90,20;98,60", 2000, 2000.0, Alert.Yellow)]
        [DataRow("12,20;98,22", 2000, 2000.0, Alert.Yellow)]
        [DataRow("93,20;98,22", 500, 2000.0, Alert.Yellow)]
        [DataRow("93,20;98,22", 2000, 430.0, Alert.Yellow)]

        [DataRow("90,20;98,75", 2000, 2000.0, Alert.Red)]
        [DataRow("3,20;98,22", 2000, 2000.0, Alert.Red)]
        [DataRow("93,20;98,22", 23, 2000.0, Alert.Red)]
        [DataRow("93,20;98,22", 2000, 12.0, Alert.Red)]

        [DataTestMethod]
        public void TestAlert(String elements, long oxygen, double battery, Alert expectedAlert)
        {
            SpaceStation testObject = new SpaceStation();
            parseElements(elements,testObject.Elements);
            testObject.Oxygen = oxygen;
            testObject.BatteryAmpereHours = battery;

            testObject.logStatus();

            Assert.AreEqual(expectedAlert, testObject.check4Problem());
        }

        private void parseElements(String input, ICollection<StructuralElement> result)
        {

            string[] elements = input.Split(";");
            foreach (String s in elements)
            {
                string[] content = s.Split(",");
                int structuralIntegrity = int.Parse(content[0]);
                int temperatureInCelsius = int.Parse(content[1]);
                result.Add(new StructuralElement(structuralIntegrity, temperatureInCelsius));
            }
        }

    }
}
