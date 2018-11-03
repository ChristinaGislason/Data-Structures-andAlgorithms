using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge16_FizzBuzzTree.Classes
{
    class Node
    {
        /// <summary>
        /// Pointer to the left child node
        /// </summary>
        public Node leftChild { get; set; }

        /// <summary>
        /// Pointer to the right child node
        /// </summary>
        public Node rightChild { get; set; }

        /// <summary>
        /// Value contained in the node
        /// </summary> 
        public object Value { get; set; }

        /// <summary>
        /// Node constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(int value, Node left = null, Node right = null)
        {
            Value = value;
            leftChild = left;
            rightChild = right;
        }

    }
}
