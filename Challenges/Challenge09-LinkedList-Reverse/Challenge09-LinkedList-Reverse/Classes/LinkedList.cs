using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge09_LinkedList_Reverse.Classes
{
    public class LinkedList
    {
        /// <summary>
        /// Points to the first node 
        /// </summary>
        public Node Head { get; set; }
        /// <summary>
        /// Node used to traverse through the Linked List
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Linked List requires a node at time of creation to be the Head
        /// </summary>
        /// <param name="node">The node that will become the head</param>
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Inserts a node to the beginning of the LL 
        /// </summary>
        /// <param name="node">the node that will be added</param>
        public void Insert(Node node)
        {
            node.Next = Head;  
            Head = node;
        }

        public void ReverseLinkedList()
        {
            Node nextNode;
            Node prevNode = null;
            Current = Head;

            while (Current != null)
            {
                nextNode = Current.Next;
                Current.Next = prevNode;
                prevNode = Current;
                Current = nextNode;
            }

            Head = prevNode;
        }

        /// <summary>
        ///	Prints the list node by node to the console	
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} --> NULL\n");
            Current = Head;
        }
    }

   



}
