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

            LinkedList thisList = new LinkedList(node1);
            thisList.Append(node2);

            thisList.Print();

        }
    }
}
