using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TDD_Example.Interfaces;

namespace TDD_Example.Models
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();

        public Money Reduce(Expression source, String to)
        {
            return source.reduce(this, to);
        }

        public int GetRate(String from, String to)
        {
            if (from == to) return 1;
            return (int)rates[new KeyValuePair<string, string>(from, to)];
        }

        public void AddRate(string from,string to,int rate)
        {
            rates.Add(new KeyValuePair<string,string>(from, to), rate);
        }
    }
}
