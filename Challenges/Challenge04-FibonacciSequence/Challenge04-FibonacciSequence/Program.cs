using System;

namespace Challenge04_FibonacciSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Recursively execute Fibonacci sequence
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibRecursive(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if(n == 1) {
                return 1; 
            }
            else
            {
                return FibRecursive(n - 1) + FibRecursive(n - 2);
            } 
        }   
    }
}
