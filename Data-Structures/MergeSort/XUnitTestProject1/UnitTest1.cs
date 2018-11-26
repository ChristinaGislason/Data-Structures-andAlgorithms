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
        public void TestMergeSortForArray()
        {
            int[] arr = { 3, 2, 1 };
            int[] expectedArr = { 1, 2, 3 };
            Program.MergeSort(arr);
            Assert.Equal(expectedArr, arr);
        }

        /// <summary>
        /// Test MergeSort method for array of size 1
        /// </summary>
        [Fact]
        public void TestMergeSortForArraySizeOne()
        {
            int[] arr = { 3 };
            int[] expectedArr = { 3 };
            Program.MergeSort(arr);
            Assert.Equal(expectedArr, arr);
        }

        /// <summary>
        /// Test MergeSort method for large array
        /// </summary>
        [Fact]
        public void TestMergeSortForLargeArray()
        {
            int[] arr = { 365, 555, 10, 252, 1001, 7 };
            int[] expectedArr = { 7, 10, 252, 365, 555, 1001 };
            Program.MergeSort(arr);
            Assert.Equal(expectedArr, arr);
        }
    }
}
