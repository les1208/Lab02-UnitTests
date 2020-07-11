using Lab02_UnitTests;
using System;
using Xunit;

namespace ATMTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ReturningBal()
        {
            Program.StartingBal = 800;
            Assert.Equal(800, Program.AddDeposit(0));
        }

        public void DepositCheck(decimal input, decimal finalResult)
        {
            Program.StartingBal = 800;
            Assert.Equal(finalResult, Program.AddDeposit(input));
        }

        public void WithdrawCheck(decimal input, decimal finalResult)
        {
            InvalidProgramException.StartingBal = 800;
            Assert.Equal(finalResult, InvalidProgramException.AddWithdraw(input));
        }
    }
}
