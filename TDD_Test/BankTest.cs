using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Interfaces;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.dollar(1), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }
        [TestMethod]
        public void TestIdentityRate()
        {
            Bank bank = new Bank();
            Assert.AreEqual(1, bank.GetRate("USD", "USD"));

            bank.AddRate("CHF", "USD", 2);
            Assert.AreEqual(2, bank.GetRate("CHF", "USD"));

        }

        [TestMethod]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.franc(2), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }

        [TestMethod]
        public void TestReduceSum()
        {
            Expression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(7), result);
        }
    }

}
