﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace StackQueueDemo.Classes
{
    public class Node
    {
        // set properties of Node class
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }

    }
}