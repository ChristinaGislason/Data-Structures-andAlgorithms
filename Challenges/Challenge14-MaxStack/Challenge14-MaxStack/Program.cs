using Challenge14_MaxStack.Classes;
using System;

namespace Challenge14_MaxStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // create nodes
            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(3);

            //create linked list
            Stack thisStack = new Stack(node1);
            thisStack.Push(node2);
            thisStack.Push(node3);
            thisStack.Print();
            Node maxNode = thisStack.getMax();
            Console.WriteLine($"Max value in stack is {maxNode.Value}");
        }
    }
}
