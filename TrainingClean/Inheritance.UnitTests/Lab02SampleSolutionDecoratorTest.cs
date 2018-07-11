using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance.Lab02.Sample.Common;
using Inheritance.Lab02.Sample.Solution;

namespace Inheritance.UnitTests
{
    [TestClass]
    public class Lab02SampleSolutionDecoratorTest
    {
        [TestMethod]
        public void TestMethod()
        {
            BatteryStub battery = new BatteryStub();

            SpaceStationModuleBasic basic = new SpaceStationModuleBasic();
            SpaceStationModuleDecoratorLiving living = new SpaceStationModuleDecoratorLiving(basic, 2, 12);
            SpaceStationModuleDecoratorSolarPanels module = new SpaceStationModuleDecoratorSolarPanels(living, battery);

            Astronaut n1 = new Astronaut("N1");
            Astronaut n2 = new Astronaut("N1");
            Astronaut n3 = new Astronaut("N1");
            Astronaut n4 = new Astronaut("N1");

            for (int i = 0; i < 50; i++)
            {
                n1.DoSomething();
                n2.DoSomething();
                n3.DoSomething();
                n4.DoSomething();
            }

            Assert.AreEqual(50, n1.FatigueInPercent);
            Assert.AreEqual(50, n2.FatigueInPercent);
            Assert.AreEqual(50, n3.FatigueInPercent);
            Assert.AreEqual(50, n4.FatigueInPercent);

            for (int i = 0; i < 100; i++)
            {
                module.ReceiveSunshine();
            }

            Assert.AreEqual(10.0d, battery.AmpereHours, 0.1d, "Should be charged 10 amperehours");

            module.RestAstronauts(n1, n2, n3, n4);

            Assert.AreEqual(38, n1.FatigueInPercent, "Should have slept in bed");
            Assert.AreEqual(38, n2.FatigueInPercent, "Should have slept in bed");
            Assert.AreEqual(49, n3.FatigueInPercent, "Should have slept in closet");
            Assert.AreEqual(49, n4.FatigueInPercent, "Should have slept in closet");
        }
    }
}
