namespace CSharpTDD
{
    internal class Money : IExpression
    {
        private int amount;

        private string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public string Currency()
        {
            return currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && Currency().Equals(money.currency);
        }

        public override string ToString()
        {
            return amount + " " + currency;
        }

        public IExpression Plus(Money addend)
        {
            return new Money(amount + addend.amount, currency);
        }
    }
}
