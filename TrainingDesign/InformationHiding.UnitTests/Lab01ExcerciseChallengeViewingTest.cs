using InformationHiding.Lab01.Excercise.Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace InformationHiding.UnitTests
{
    [TestClass]
    public class Lab01ExcerciseChallengeViewingTest
    {
        public const string LifeOfBrianBluRay = 
            "All right, but apart from the sanitation, medicine, education, wine, public order, " +
            "irrigation, roads, the fresh water system and public health, what have the Romans ever done for us?";

        [TestMethod]
        public void TestViewing()
        {
            // Let´s watch The Dark Knight on channel 3
            SatelliteReceiver sat = new SatelliteReceiver();
            sat.Power(true);
            sat.SwitchChannel(3);

            AVReceiver avr = new AVReceiver();
            Speakers speakers = new Speakers();
            avr.Power(true);
            avr.PlugIn(1, sat);
            avr.ConnectSpeakers(speakers);
            avr.ChangeSource(1);

            TV tv = new TV();
            tv.Power(true);
            tv.PlugIn(avr);

            string outputVideo = Encoding.Default.GetString(tv.Watch());
            Assert.AreEqual("You wanna know how I got these scars?", outputVideo);

            BluRayPlayer bp = new BluRayPlayer();
            bp.Power(true);
            bp.InsertDisc(LifeOfBrianBluRay);

            avr.PlugIn(2, bp);
            avr.ChangeSource(2);

            outputVideo = Encoding.Default.GetString(tv.Watch());
            Assert.AreEqual(LifeOfBrianBluRay, outputVideo);
        }
    }
}
