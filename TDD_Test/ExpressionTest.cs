using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Interfaces;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void TestSimpleAddition()
        {
            Money five = Money.dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(10), reduced);
        }
        [TestMethod]
        public void TestPlusReturnsSum()
        {
            Money five = Money.dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.AreEqual(five, sum.Augend);
            Assert.AreEqual(five, sum.Addend);
        }
    }

}
