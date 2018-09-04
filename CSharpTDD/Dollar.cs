using System;

namespace CSharpTDD
{
    internal class Dollar
    {
        private int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
         }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }


    }
}