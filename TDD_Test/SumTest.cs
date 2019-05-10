using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Example.Interfaces;
using TDD_Example.Models;
namespace TDD_Test
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void TestSumPlusMoney()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(15), result);
        }

        [TestMethod]
        public void TestSumTimes()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Times(2);
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(20), result);
        }
    }

}
