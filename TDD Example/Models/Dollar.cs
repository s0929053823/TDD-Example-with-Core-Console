using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Dollar : Money
    {

        public Dollar(int amount)
        {
            this._amount = amount;
            this._currency = "USD";
        }

        public Dollar(int amount,string currency)
        {
            this._amount = amount;
            this._currency = "USD";
        }

        public override Money times(int multiplier)
        {
            return Money.dollar(this._amount * multiplier);
        }

        public string currency()
        {
            return this._currency;
        }

    }
}
