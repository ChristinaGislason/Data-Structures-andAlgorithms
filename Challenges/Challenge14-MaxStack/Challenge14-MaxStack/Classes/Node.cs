using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge14_MaxStack.Classes
{
    class Node
    {
        /// <summary>
        /// pointer to the next node
        /// </summary>
        public Node Next { get; set; }
        /// <summary>
        /// value contained in the node
        /// </summary> 
        public int Value { get; set; }

        /// <summary>
        /// node constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
