using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Interfaces;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsFalse(Money.franc(5).Equals(Money.franc(6)));
        }

        [TestMethod]
        public void TestDifferentClassEquality()
        {
            Assert.IsFalse(new Franc(5).Equals(Money.dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(Money.franc(5)));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.dollar(1).Currency);
            Assert.AreEqual("CHF", Money.franc(1).Currency);
        }

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
