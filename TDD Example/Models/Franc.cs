using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Franc
    {
        private int _amount;

        public Franc(int amount)
        {
            this._amount = amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Franc Franc = (Franc)obj;
            return _amount == Franc._amount;
        }
    }
}
