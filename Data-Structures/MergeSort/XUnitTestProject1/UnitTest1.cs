using MergeSort;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test MergeSort method to return sorted array
        /// </summary>
        [Fact]
        public void TestMergeSort()
        {
            int[] arr = { 3, 2, 1 };
            int[] expectedArr = { 1, 2, 3 };
            Program.MergeSort(arr);
            Assert.Equal(expectedArr, arr);
        }
    }
}
