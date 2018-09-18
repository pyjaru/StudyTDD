using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    internal abstract class Money
    {
        protected internal int amount;

        protected internal string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public abstract Money Times(int multiplier);

        public string Currency()
        {
            return currency;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType().Equals(money.GetType());
        }
    }
}
