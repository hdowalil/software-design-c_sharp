using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance.Lab02.Sample.Common;
using Inheritance.Lab02.Sample.Solution;
using Inheritance.Lab02.Excercise.Common;
using Inheritance.Lab02.Excercise.Solution;

namespace Inheritance.UnitTests
{
    [TestClass]
    public class Lab02ExcerciseSolutionTrainerDecoratorTest
    {
        [TestMethod]
        public void TestMethod()
        {
            SpeakingDoll personalKen = new PersonalDollDecorator("Valentina", new Ken());
            Assert.AreEqual("Hello Valentina, I am Ken", personalKen.Speak());

            SpeakingDoll personalBarbie = new PersonalDollDecorator("Valentina", new Barbie());
            Assert.AreEqual("Hello Valentina, I am Barbie", personalBarbie.Speak());
        }
    }
}
