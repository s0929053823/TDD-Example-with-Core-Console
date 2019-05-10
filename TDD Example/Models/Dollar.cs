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
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

    }
}
