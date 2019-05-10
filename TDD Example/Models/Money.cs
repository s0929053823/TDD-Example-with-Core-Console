using System;
using TDD_Example.Interfaces;

namespace TDD_Example.Models
{
    public class Money : Expression
    {
        protected int _amount;
        protected string _currency;

        public int Amount => this._amount;

        public string Currency => this._currency;

        public Expression Times(int multiplier)
        {
            return new Money(this._amount * multiplier, this._currency);
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }


        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }


        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return( _amount == money._amount&& this.Currency.Equals(money.Currency));
        }


        public Money Reduce(Bank bank, String to)
        {
            int rate = bank.GetRate(this._currency, to);
            return new Money(this._amount / rate, to);
        }

        public Money()
        {

        }

        public Money(int amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }

   
        //For Debug
        public String toString()
        {
            return this._amount + " " + this._currency;
        }


    }

  
}
