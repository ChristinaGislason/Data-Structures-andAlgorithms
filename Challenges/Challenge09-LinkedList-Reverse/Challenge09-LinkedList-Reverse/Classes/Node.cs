using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge09_LinkedList_Reverse.Classes
{
    public class Node
    {
        /// <summary>
        /// pointer to the next node
        /// </summary>
        public Node Next { get; set; }
        /// <summary>
        /// value contained in the node
        /// </summary> 
        public object Value { get; set; }

        /// <summary>
        /// node constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(object value)
        {
            Value = value;
        }
    }
}
