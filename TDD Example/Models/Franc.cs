using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Franc :Money
    {

        public Franc(int amount)
        {
            this._amount = amount;
            this._currency = "CHF";
        }

        public Franc(int amount,string currency)
        {
            this._amount = amount;
            this._currency = "CHF";
        }

        public override Money times(int multiplier)
        {
            return Money.franc(this._amount * multiplier);
        }

        public string currency()
        {
            return this._currency;
        }
    }
}
