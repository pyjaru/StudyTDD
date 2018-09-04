using System;

namespace CSharpTDD
{
    internal class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public void Times(int multiplier)
        {
            amount *= multiplier;
        }
    }
}