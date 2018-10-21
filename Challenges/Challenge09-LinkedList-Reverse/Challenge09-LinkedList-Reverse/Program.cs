using Challenge09_LinkedList_Reverse.Classes;
using System;

namespace Challenge09_LinkedList_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // create nodes
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            //create linked list
            LinkedList thisList = new LinkedList(node1);
            thisList.Insert(node2);
            thisList.Insert(node3);
            thisList.Print();
            thisList.ReverseLinkedList();
            thisList.Print();
        }
    }
}
