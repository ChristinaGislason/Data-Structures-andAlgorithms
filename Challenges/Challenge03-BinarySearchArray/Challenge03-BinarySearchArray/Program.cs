using System;

namespace Challenge03_BinarySearchArray
{
    public class Program
    {      
        public static void Main(string[] args)
        {
            int[] testArray = { 4, 8, 15, 16, 23, 42 };
            int testInvalidResult = -1;
            int testSearchKey = 15;

            //call the method to search the array for search key
            Console.WriteLine(BinarySearch(testArray, testSearchKey, testInvalidResult));
        }

        public static int BinarySearch(int[] numArray, int searchKey, int invalidResult)
        {
            //declare variables for index positions of array
            int start = 0;
            int end = (numArray.Length) - 1;
            int middle; 

            //return index of the array's element that is equal to the search key
            while (start <= end)
            {
                middle = (start + end) / 2;

                if (numArray[middle] == searchKey)
                {
                    return middle;
                }
                else if (numArray[middle] < searchKey)
                {
                    start = middle + 1;          
                }
                else
                {
                    end = middle - 1;                  
                }
            }

            //return -1 if the element does not exist in the array
            return invalidResult;
        }       
    }
}
