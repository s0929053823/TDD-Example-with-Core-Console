using System;
using TDD_Example.Interfaces;

namespace TDD_Example.Models
{
    public class Money : Expression
    {
        protected int _amount;
        protected string _currency;

        public int Amount { get => this._amount; }

        public string Currency { get => this._currency; }

        public virtual Money times(int multiplier)
        {
            return null;
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
            return( _amount == money._amount&& this.currency().Equals(money.currency()));
        }

        public String currency()
        {
            return this._currency;
        }
        public Money reduce(Bank bank, String to)
        {
            int rate = bank.GetRate(this._currency, to);
            return new Money(this._amount / rate, to);
        }

        public Money(int amount, string currency)
        {
            this._amount = amount;
            this._currency = currency;
        }


        public Expression plus(Money addend)
        {
            return new Sum(this, addend);
        }

        //For Debug
        public String toString()
        {
            return this._amount + " " + this._currency;
        }


    }

  
}
