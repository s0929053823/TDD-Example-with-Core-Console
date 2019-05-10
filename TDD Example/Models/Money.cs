using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Example.Models
{
    public class Money
    {
        protected int _amount;

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount;
        }
    }

  
}
