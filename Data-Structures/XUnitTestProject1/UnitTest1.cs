using QuickSort;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test QuickSort method to return sorted array
        /// </summary>
        [Fact]
        public void TestQuickSortForArray()
        {
            int[] arr = { 3, 2, 1 };
            int[] expectedArr = { 1, 2, 3 };
            Program.QuickSort(arr, 0, arr.Length -1);
            Assert.Equal(expectedArr, arr);
        }
    }
}
