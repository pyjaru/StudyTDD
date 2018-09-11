using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    internal class Money
    {
        protected internal int amount;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType().Equals(money.GetType());
        }
    }
}
