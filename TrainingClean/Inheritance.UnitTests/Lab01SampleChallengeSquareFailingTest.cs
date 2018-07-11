using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance.Lab01.Sample.Challenge;

namespace Inheritance.UnitTests
{
    [TestClass]
    public class Lab01SampleChallengeSquareFailingTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Rectangle rec = new Square();
            rec.SetHeight(42);
            rec.SetWidth(23);

            Assert.AreEqual(42, rec.GetHeight());
        }
    }
}
