using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTDD
{
    internal class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair,int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            int rate = rates[new Pair(from, to)];
            return rate;
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }
    }
}