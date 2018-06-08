using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelfDocumentation.Lab01.Sample.Challenge;

namespace SelfDocumentation.UnitTests
{
    [TestClass]
    public class Lab01SampleChallengeMyObjectTest
    {
        [DataRow(true, 10, 1, true, 2000)]
        [DataRow(false, 10, 1, true, 1000)]
        [DataRow(false, 50, 3, false, 2000)]
        [DataTestMethod]
        public void TestValue(bool related, int percentage, int years, bool ext, long expected)
        {
            MyObject myObj = new MyObject(related, percentage, years, ext);
            Assert.AreEqual(expected, myObj.Value);
        }
    }
}
