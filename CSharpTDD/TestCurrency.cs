using System;
using Xunit;

namespace CSharpTDD
{
    public class TestCurrency
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.amount);
        }
    }
}
