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
            Dollar product = five.Times(2);
            Assert.Equal(10, product.amount);
            product = five.Times(3);
            Assert.Equal(15, product.amount);

        }
    }
}
