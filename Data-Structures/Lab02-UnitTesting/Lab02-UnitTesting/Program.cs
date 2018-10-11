using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        public static decimal Balance = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your ATM");
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static bool deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public static decimal withdraw(decimal amount)
        {
            Balance -= amount;

            return Balance;
        }

        public static void updateBalance(decimal newBalance)
        {
            Balance = newBalance;
        }

    }
}
