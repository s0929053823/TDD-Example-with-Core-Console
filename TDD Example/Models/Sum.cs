using System;
using System.Collections.Generic;
using System.Text;
using TDD_Example.Interfaces;

namespace TDD_Example.Models
{
    public class Sum : Expression
    {
        public Money augend, addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money reduce(Bank bank, String to)
        {
            int amount = augend.Amount + addend.Amount;
            return new Money(amount, to);
        }
    }
}
