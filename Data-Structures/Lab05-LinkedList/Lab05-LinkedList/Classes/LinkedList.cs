﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_LinkedList.Classes
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
		/// Inserts a node to the beginning of the LL (sometimes called Insert)
		/// </summary>
		/// <param name="node">the node that will be added</param>
		public void Insert(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
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

        /// <summary>
		/// Appends a node to the end of the LL	
		/// </summary>
		/// <param name="newNode">the node to be added</param>
		public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Current = Head;
        }

        /// <summary>
		/// inserts a node into the list before a given node		
		/// </summary>
		/// <param name="newNode">the node to be added</param>
		/// <param name="existingNode">the node that will follow the newly added node</param>
		public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Insert(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// inserts a node into the list after a given node
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;            
            }
            newNode.Next = Current.Next;
            Current.Next = newNode;
            Current = Head;
        }
    }
}
