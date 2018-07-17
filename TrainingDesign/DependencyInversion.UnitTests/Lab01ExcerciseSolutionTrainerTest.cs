using DependencyInversion.Lab01.Excercise.Solution.Trainer.Spacestation;
using DependencyInversion.Lab01.Excercise.Solution.Trainer.Universe;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DependencyInversion.UnitTests
{
    [TestClass]
    public class Lab01ExcerciseSolutionTrainerTest
    {
        [TestMethod]
        public void TestApproAndCollision()
        {
            Space space = new Space();

            Debris asteroid1 = space.DeployDebris(1000, -1000, 1000, 25);
            Debris asteroid2 = space.DeployDebris(1000, 1000, 1000, 50);

            SpaceStation station = new SpaceStation(space, 0, 0, 0);

            for (int i = 0; i < 850; i++)
            {
                space.MoveDebris(asteroid1, -1, 1, -1);
                Assert.IsNull(station.CurrentAlert, "There should not be an alert yet!");
            }

            for (int i = 0; i < 100; i++)
            {
                space.MoveDebris(asteroid1, -1, 1, -1);
            }
            Assert.IsNotNull(station.CurrentAlert , "There should be an alert now!");
            Assert.AreEqual(Alert.Yellow, station.CurrentAlert, "There should be a yellow alert now! asteroid 1 is close to our station");

            // lets move station out of the way
            for (int i = 0; i < 850; i++)
            {
                space.MoveDebris(station, 1, 1, 1);
            }
            Assert.IsNull(station.CurrentAlert, "There should not be an alert any more, we have moved!");

            for (int i = 0; i < 100; i++)
            {
                space.MoveDebris(station, 1, 1, 1);
            }
            Assert.IsNotNull(station.CurrentAlert, "There should be an alert now!");
            Assert.AreEqual(Alert.Yellow, station.CurrentAlert, "There should be a yellow alert now! asteroid 2 is close to our station");

            for (int i = 0; i < 21; i++)
            {
                space.MoveDebris(station, 1, 1, 1);
            }
            Assert.IsNotNull(station.CurrentAlert, "There should be an alert now!");
            Assert.AreEqual(Alert.Red, station.CurrentAlert, "Collision with asteroid2 - RED ALERT!!");
        }

    }
}
