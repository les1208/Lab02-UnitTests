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
    }
}
