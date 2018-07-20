using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modularization.Lab01.Excercise.Challenge;

namespace Modularization.UnitTests
{
    [TestClass]
    public class Lab01ExcerciseChallengeTest
    {
        [TestMethod]
        public void PlaceOrderTest()
        {
            Customer c = new Customer();

            // we ain´t got nuffin yet
            Assert.AreEqual(0, c.GetAmountOfMyProducts(Product.A));
            Assert.AreEqual(0, c.GetAmountOfMyProducts(Product.B));
            Assert.AreEqual(0, c.GetAmountOfMyProducts(Product.C));
            Assert.AreEqual(0, c.GetAmountOfMyProducts(Product.D));

            // there should be 10 in stock
            Assert.IsTrue(Stock.IsAvailable(Product.A, 10));
            Assert.IsTrue(Stock.IsAvailable(Product.B, 10));
            Assert.IsTrue(Stock.IsAvailable(Product.C, 10));
            Assert.IsTrue(Stock.IsAvailable(Product.D, 10));
            // but not 11
            Assert.IsFalse(Stock.IsAvailable(Product.A, 11));
            Assert.IsFalse(Stock.IsAvailable(Product.B, 11));
            Assert.IsFalse(Stock.IsAvailable(Product.C, 11));
            Assert.IsFalse(Stock.IsAvailable(Product.D, 11));

            c.PlaceAnOrder(new OrderPosition(Product.A, 4), 
                new OrderPosition(Product.C, 3), 
                new OrderPosition(Product.A, 6));

            // no we have some stuff
            Assert.AreEqual(10, c.GetAmountOfMyProducts(Product.A));
            Assert.AreEqual(0, c.GetAmountOfMyProducts(Product.B));
            Assert.AreEqual(3, c.GetAmountOfMyProducts(Product.C));
            Assert.AreEqual(0, c.GetAmountOfMyProducts(Product.D));

            // we should have in stock now
            Assert.IsTrue(Stock.IsAvailable(Product.A, 0));
            Assert.IsTrue(Stock.IsAvailable(Product.B, 10));
            Assert.IsTrue(Stock.IsAvailable(Product.C, 7));
            Assert.IsTrue(Stock.IsAvailable(Product.D, 10));
            // but not:
            Assert.IsFalse(Stock.IsAvailable(Product.A, 1));
            Assert.IsFalse(Stock.IsAvailable(Product.B, 11));
            Assert.IsFalse(Stock.IsAvailable(Product.C, 8));
            Assert.IsFalse(Stock.IsAvailable(Product.D, 11));

        }
    }
}
