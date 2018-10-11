using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02_Unit_Testing
{
    public class UnitTest1
    {   
        // test to view account balance
        [Fact]
        public void CanReturnDefaultBalance()
        {
            Program.updateBalance(0);
            Assert.Equal(0, Program.ViewBalance());
        }

        [Fact]
        public void CanDepositMoney()
        {
            Program.updateBalance(0);
            Program.deposit(5);
            Assert.Equal(5, Program.ViewBalance());
        }

        [Fact]
        public void CannotDepositNegativeAmount()
        {
            Program.updateBalance(0);
            Program.deposit(-5);
            Assert.Equal(0, Program.ViewBalance());
        }

        [Fact]
        public void CanWithdrawMoney()
        {
            Program.updateBalance(0);
            Program.deposit(5);
            Program.withdraw(3);
            Assert.Equal(2, Program.ViewBalance());
        }
    }
}
