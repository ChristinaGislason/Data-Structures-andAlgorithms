using System;

namespace Challenge02_ShiftArray
{
    class Program
    {
        //InsertShiftArray();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputArray = { 1, 2, 4, 5 };
            int[] result = InsertShiftArray(inputArray, 3);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{result[i]}");
            }

        }

        static int[] InsertShiftArray(int[] inputArray, int num)
        {

            //declare variables and initialize inputs for the input array

            int[] outputArray = new int[inputArray.Length + 1];

            //loop through input array to determine that once you hit the middle of the array, a new number will be inserted into the new array 
            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i < Math.Ceiling((double)(inputArray.Length / 2)))
                {
                    outputArray[i] = inputArray[i];
                }
                if (i == Math.Ceiling((double)(inputArray.Length / 2)))
                {
                    outputArray[i] = num;
                }
                if (i > Math.Ceiling((double)(inputArray.Length / 2)))
                {
                    outputArray[i] = inputArray[i - 1];
                }
            }

            return outputArray;
        }
    }
}
