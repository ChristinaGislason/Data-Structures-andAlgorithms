using System;

namespace Challenge03_BinarySearchArray
{
    class Program
    {
        //call the method to search the array for search key
        BinarySearch(); 

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numArray = { 4, 8, 15, 16, 23, 42 };
            int invalidResult = -1;
            int searchKey = 15;
        }

        public static int BinarySearch(int[] numArray, int searchKey, int start, int end)
        {
            //declare variables for index positions of array
            int start = 0;
            int end = 5;
            int middle = (numArray.Length - 1) / 2;

            //return index of the array's element that is equal to the search key
            while (start <= end)
            {
                if (numArray[middle] == searchKey)
                {
                    return middle;
                }
                else if (numArray[middle] < searchKey)
                {
                    start = middle + 1;
                    return start;
                }
                else
                {
                    end = middle - 1;
                    return end;
                }
                
            }
            //return -1 if the element does not exist in the array
            return invalidResult;
        }       
    }
}
