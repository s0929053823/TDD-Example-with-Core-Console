using System;
using System.Collections.Generic;
using System.Text;
using TDD_Example.Interfaces;

namespace TDD_Example.Models
{
    public class Sum : Expression
    {
        private Expression augend, addend;

        public Expression Augend => this.augend;
        public Expression Addend => this.addend;


        public Sum(Expression augend, Expression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, String to)
        {
            int amount = augend.Reduce(bank,to).Amount + addend.Reduce(bank,to).Amount;
            return new Money(amount, to);
        }
        public Expression Plus(Expression addend)
        {
            return null;
        }
    }
}
