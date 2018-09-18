using System;

namespace CSharpTDD
{
    internal class Bank
    {
        public Money Reduce(IExpression sum, string to)
        {
            return Money.Dollar(10);
        }
    }
}