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
            Franc five = new Franc(5);
            Franc product = five.times(2);
            Assert.AreEqual(new Franc(10), product);
            product = five.times(3);
            Assert.AreEqual(new Franc(15), product);
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        }
    }
}
