using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02_UnitTesting_Test
{
    public class UnitTest1
    {
        [Fact]

        public void ViewBalance()
        {
            Assert.Equal("balance", Program.ViewBalance(100));
        }
    }
}
