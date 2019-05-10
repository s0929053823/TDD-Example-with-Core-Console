using System;
using System.Collections.Generic;
using System.Text;
using TDD_Example.Models;

namespace TDD_Example.Interfaces
{
    public interface Expression
    {
        Money Reduce(Bank bank, String to);
        Expression Plus(Expression addend);
    }
}
