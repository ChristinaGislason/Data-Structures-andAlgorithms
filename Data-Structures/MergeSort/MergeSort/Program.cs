using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArray = { 4, 7, 2, 5, 1, 8, 6, 3 };
            MergeSort(myArray);
        }

        static void MergeSort(int[] myArray)
        {
            if(myArray.Length > 1)
            {
                // Split array into two and establish sizes of each half of the array
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                // Places the first half of the original array into a smaller array
                int[] leftArray = new int[leftSize];
                Array.Copy(myArray, 0, leftArray, 0, leftSize);

                // Places the second half of the original array into a smaller array
                int[] rightArray = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, rightArray, 0, rightSize);

                MergeSort(leftArray);
                MergeSort(rightArray);
                Merge(leftArray, rightArray, myArray);
            }
            Console.WriteLine(string.Join(",", myArray));
        }


    }
}
