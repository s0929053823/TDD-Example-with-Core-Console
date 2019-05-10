using System;
using System.Collections.Generic;
using System.Text;
using TDD_Example.Models;

namespace TDD_Example.Interfaces
{
    public interface Expression
    {
        Money reduce(Bank bank, String to);
    }
}
