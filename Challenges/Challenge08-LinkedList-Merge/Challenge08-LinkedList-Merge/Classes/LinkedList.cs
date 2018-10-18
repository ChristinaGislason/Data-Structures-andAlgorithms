using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge08_LinkedList_Merge.Classes
{
    public class LinkedList
    {
        /// <summary>
		///	Always points to the first node in the LL
		/// </summary>
		public Node Head { get; set; }

        /// <summary>
        ///	The node that is used to traverse through the LL
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        ///	LL requires a node at time of creation to be the HEAD
        /// </summary>
        /// <param name="node">the node that will become the head</param>
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
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
