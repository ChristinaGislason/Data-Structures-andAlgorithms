using Hashtables.Classes;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add four elements to Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("First", "Tommy");
            hashtable.Add("Second", "Jill");
            hashtable.Add("Third", "Peter");
            hashtable.Add("Fourth", "Sunny");

            // See if the Hashtable contains this key.
            //Console.WriteLine(hashtable.ContainsKey("Perimeter"));

            // Test the Contains method.
            // ... It works the same way.
            //Console.WriteLine(hashtable.Contains("Area"));
        }
    }
}
