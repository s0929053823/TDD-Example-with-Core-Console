using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        }
    }
    
}
