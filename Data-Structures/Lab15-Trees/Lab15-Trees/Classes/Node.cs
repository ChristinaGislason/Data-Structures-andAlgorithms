using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Trees.Classes
{
    class Node
    {
        private Node node;

        /// <summary>
        /// pointer to the left child node
        /// </summary>
        public Node leftChild { get; set; }

        /// <summary>
        /// pointer to the right child node
        /// </summary>
        public Node rightChild { get; set; }

        /// <summary>
        /// value contained in the node
        /// </summary> 
        public object Value { get; set; }

        /// <summary>
        /// node constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(object value, Node left = null, Node right = null)
        {
            Value = value;
            leftChild = left;
            rightChild = right;
        }

    }
}
