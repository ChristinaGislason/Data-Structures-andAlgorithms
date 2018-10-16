using System;
using Lab05_LinkedList.Classes;

namespace Lab05_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(7);
            Node node2 = new Node("Hello");
            Node node3 = new Node("puppies");
            Node node4 = new Node("100");

            LinkedList thisList = new LinkedList(node1);
            thisList.Append(node2);          
            thisList.AddBefore(node3, node1);
            thisList.AddAfter(node4, node2);
            thisList.Print();
            Console.ReadLine();

        }
    }
}
