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

        /// <summary>
        /// Test QuickSort method for array of size 1
        /// </summary>
        [Fact]
        public void TestQuickSortForArraySizeOne()
        {
            int[] arr = { 3 };
            int[] expectedArr = { 3 };
            Program.QuickSort(arr, 0, arr.Length -1);
            Assert.Equal(expectedArr, arr);
        }

        /// <summary>
        /// Test QuickSort method for large array
        /// </summary>
        [Fact]
        public void TestQuickSortForLargeArray()
        {
            int[] arr = { 365, 555, 10, 252, 1001, 7 };
            int[] expectedArr = { 7, 10, 252, 365, 555, 1001 };
            Program.QuickSort(arr, 0, arr.Length -1);
            Assert.Equal(expectedArr, arr);
        }
    }
}
