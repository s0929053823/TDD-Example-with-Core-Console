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
        }

        public Franc times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }
    }
}
