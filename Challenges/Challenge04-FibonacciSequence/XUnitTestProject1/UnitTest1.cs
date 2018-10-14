using System;
using Xunit;
using Challenge04_FibonacciSequence;
using static Challenge04_FibonacciSequence.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestPosition0inFib()
        {
            Assert.Equal(0, Program.FibRecursive(0));
        }

        [Fact]
        public void TestPosition1inFib()
        {
            Assert.Equal(1, Program.FibRecursive(1));
        }

        [Fact]
        public void TestPosition6inFib()
        {
            Assert.Equal(8, Program.FibRecursive(6));
        }
    }
}
