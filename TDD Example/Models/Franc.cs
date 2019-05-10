using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Franc :Money
    {

        public Franc(int amount) : base(amount,"CHF")
        {
         
        }

        public Franc(int amount,string currency): base(amount, "CHF")
        {
            
        }

        //public override Expression times(int multiplier)
        //{
        //    return Money.franc(this._amount * multiplier);
        //}

        public string currency()
        {
            return this._currency;
        }
    }
}
