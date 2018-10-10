using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02_Unit_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            Assert.Equal("100", Program.ViewBalance(100));
        }
        /*
        [Fact]
        public void CanDeposit()
        {
            Assert.Equal("90", Program.CanDeposit(10));
        }
        */
    }
}
