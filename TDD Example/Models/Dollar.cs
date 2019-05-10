using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Dollar : Money
    {

        public Dollar(int amount) : base(amount,"USD")
        {
         
        }

        public Dollar(int amount,string currency) : base(amount, "USD")
        {
           
        }

        //public override Expression times(int multiplier)
        //{
        //    return Money.dollar(this._amount * multiplier);
        //}


    }
}
