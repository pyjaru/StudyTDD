namespace CSharpTDD
{
    internal interface IExpression
    {
        Money Reduce(Bank bank, string to);
        IExpression Plus(IExpression addend);
    }
}