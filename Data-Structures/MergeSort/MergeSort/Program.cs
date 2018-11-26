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
            if (myArray.Length > 1)
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

        static int[] Merge(int[] leftArray, int[] rightArray, int[] mainArray)
        {
            // Left pointer
            int i = 0;
            // Right pointer
            int j = 0;
            // End array pointer
            int k = 0;

            // Confirm that each array being compared still has pointers
            while (i < leftArray.Length && j < rightArray.Length)
            {
                // If the value of left array is less than the value of the right array
                if (leftArray[i] <= rightArray[j])
                {
                    // Populate the main array with the lower value
                    mainArray[k] = leftArray[i];
                    // Immediately increment i
                    i++;
                }
                else
                {
                    // Populate the main array with the lower value from the right array 
                    mainArray[k] = rightArray[j];
                    // Increment the pointer of the right array
                    j++;
                }
                // Increment the pointer in the main array
                k++;
            }

            if (i == leftArray.Length)
            {
                // Copy remaining right array into main array
                Array.Copy(rightArray, j, mainArray, k, rightArray.Length - j);
            }
            else
            {
                // Copy remaining left array into main array
                Array.Copy(leftArray, i, mainArray, k, leftArray.Length - i);
            }

            return mainArray;

        }
    }
}
