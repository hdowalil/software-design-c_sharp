using DependencyInversion.Lab01.Excercise.Challenge.Spacestation;
using DependencyInversion.Lab01.Excercise.Challenge.Universe;
using DependencyInversion.Lab02.Sample.Solution.A;
using DependencyInversion.Lab02.Sample.Solution.B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace DependencyInversion.UnitTests
{
    [TestClass]
    public class Lab02SampleSolutionTest
    {
        [TestMethod]
        public void TestCylicFreeVersionWithDI()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<WhatC4Needs, C3ToPackageBAdapter>();
            C4 c4 = container.Resolve<C4>();

            C3ToPackageBAdapter adapter = (C3ToPackageBAdapter) c4.WhatINeed;
            Assert.AreEqual(0, adapter.Called);

            c4.DoC4();
            Assert.AreEqual(1, adapter.Called);
        }

    }
}
