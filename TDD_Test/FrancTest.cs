using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class FrancTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.franc(5);
            Assert.AreEqual(new Franc(10), five.times(2));
            Assert.AreEqual(new Franc(15), five.times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        }
    }
}
