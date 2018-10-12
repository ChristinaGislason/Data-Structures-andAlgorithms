using System;

namespace Challenge04_SumMatrixRows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SumMatrixRows();
        }

        static void SumMatrixRows()
        {
            // initializers for matrix rows indexed at 0, 1, 2
            int[,] inputMatrix = new int[3,3]
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 }
            };           
            int[] outputArray;
            int sum;


            // iterate through rows in matrix to sum values 
            // output sum of each row in a single array
            for (int j = 0; j < inputMatrix.Length; j++)
            {
                //for (int i = 0; i < inputMatrix.getLength(i); i++)                         
                //{
                //    sum += inputMatrix[j, i];
                //    //Console.WriteLine("{0}", outputArray[i, j]);
                //    Console.WriteLine("{outputArray}")
                //}
            }
        }
    }


}
