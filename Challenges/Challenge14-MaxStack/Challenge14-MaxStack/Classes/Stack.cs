using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge14_MaxStack.Classes
{
    class Stack
    {
        /// <summary>
        /// Points to the top node in the stack 
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// Stack requires a node at time of creation to be the top
        /// </summary>
        /// <param name="node">The node that will become the head</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Pushes or add a node to the top of the Stack
        /// </summary>
        /// <param name="node">the node that will be added</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pops or removes a node to the top of the Stack
        /// </summary>
        /// <param name="node">the node that will be added</param>
        public Node Pop()
        {
            Node Temp = Top;
            Top = Top.Next;
            Temp.Next = null;
            return Temp;
        }

        public Node getMax()
        {      
            Node maxNode = Top;
            Node Temp = Top;

            while (Temp.Next != null)
            {
               if(Temp.Value > maxNode.Value) 
                {
                    maxNode = Temp;
                }
                Temp = Temp.Next;                        
            }
            return maxNode;
        }

        /// <summary>
        ///	Prints the stack node by node to the console	
        /// </summary>
        public void Print()
        {
            Node Temp = Top;
            while (Temp.Next != null)
            {
                Console.Write($"{Temp.Value} --> ");
                Temp = Temp.Next;
            }

            Console.Write($"{Temp.Value} --> NULL\n");
        }
    }
}
