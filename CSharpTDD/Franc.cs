namespace CSharpTDD
{
    internal class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(object obj)
        {
            Franc Franc = (Franc)obj;
            return amount == Franc.amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
    }
}