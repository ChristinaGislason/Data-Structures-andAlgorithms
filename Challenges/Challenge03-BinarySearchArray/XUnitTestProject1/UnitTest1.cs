using System;
using Xunit;
using Challenge03_BinarySearchArray;
using static Challenge03_BinarySearchArray.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArray = { 4, 8, 15, 16, 23, 42 };
            int testInvalidResult = -1;
            int testSearchKey = 15;

            Assert.Equal(2, BinarySearch(testArray, testSearchKey, testInvalidResult));
        }
    }
}
