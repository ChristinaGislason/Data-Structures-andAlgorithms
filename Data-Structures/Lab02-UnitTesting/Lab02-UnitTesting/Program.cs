using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        int num;
        int deposit;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ViewBalance(int num)
        {
            return num.ToString();
        }

        /*
        public static string CanDeposit(int deposit)
        {
            return (num + deposit).ToString();
        }
        */
    }
}
