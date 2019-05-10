using System;
using System.Collections.Generic;
using System.Text;
using TDD_Example.Interfaces;

namespace TDD_Example.Models
{
    public class Sum : Expression
    {
        public Expression Augend { get; }
        public Expression Addend { get; }


        public Sum(Expression augend, Expression addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(Bank bank, String to)
        {
            int amount = Augend.Reduce(bank,to).Amount + Addend.Reduce(bank,to).Amount;
            return new Money(amount, to);
        }
        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }

    }
}
