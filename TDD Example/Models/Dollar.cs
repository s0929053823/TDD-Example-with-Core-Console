using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Dollar
    {
        private int _amount;

        public Dollar(int amount)
        {
            this._amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return _amount == dollar._amount;
        }
    }
}
