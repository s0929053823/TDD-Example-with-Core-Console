using System;

namespace TDD_Example.Models
{
    public abstract class Money
    {
        protected int _amount;
        protected string _currency;


        public abstract Money times(int multiplier);
     

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

        //For Debug
        public String toString()
        {
            return this._amount + " " + this._currency;
        }
    }

  
}
