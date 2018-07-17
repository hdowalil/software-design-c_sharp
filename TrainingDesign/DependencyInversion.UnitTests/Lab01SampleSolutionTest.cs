using DependencyInversion.Lab01.Sample.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace DependencyInversion.UnitTests
{
    [TestClass]
    public class Lab01SampleSolutionTest
    {
        [TestMethod]
        public void TestWarningObserver()
        {
            BankAccount account = new BankAccount();
            account.ReceiveMoney(10000);

            BankAccountObserverWarning observer = new BankAccountObserverWarning();
            account.RegisterObserver(observer.AvailableAmountUpdated);

            Assert.IsFalse(observer.Warning, "There should not be a warning yet!");

            account.ReceiveMoney(1000);
            Assert.IsFalse(observer.Warning, "There should not be a warning yet!");

            account.SpendMoney(9000);
            Assert.IsFalse(observer.Warning, "There should not be a warning yet!");

            account.SpendMoney(1901);
            Assert.IsTrue(observer.Warning, "There should be a warning now, as we have only 99 bucks left!");

        }
        
        [TestMethod]
        public void TestObserver()
        {
            int calls = 0;

            BankAccount account = new BankAccount();
            account.ReceiveMoney(10000);

            account.RegisterObserver(amount => { Interlocked.Increment(ref calls); });

            Assert.AreEqual(0, calls, "Should not have been called, just because of adding it!");

            account.SpendMoney(10);
            Assert.AreEqual(1, calls, "Should have been called once now!");

        }
    }
}
