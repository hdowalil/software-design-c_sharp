using InformationHiding.Lab01.Excercise.Challenge;
using InformationHiding.Lab01.Excercise.Solution.Trainer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace InformationHiding.UnitTests
{
    [TestClass]
    public class Lab01ExcerciseSolutionTrainerViewingTest
    {

        [TestMethod]
        public void TestViewing()
        {
            // we cannot (!) even acces TV, BluRayPlayer etc. anymore!
            ViewingFacade viewing = new ViewingFacade();

            byte[] result = viewing.WatchBluRay(Lab01ExcerciseChallengeViewingTest.LifeOfBrianBluRay);
            string outputVideo = Encoding.Default.GetString(result);
            Assert.AreEqual(Lab01ExcerciseChallengeViewingTest.LifeOfBrianBluRay, outputVideo);

            viewing.StopWatching();
        }
    }
}
