using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class DollarTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
