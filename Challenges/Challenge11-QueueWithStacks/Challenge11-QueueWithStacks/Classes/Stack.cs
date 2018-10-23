using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge11_QueueWithStacks.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public int Size { get; set; } = 1;
        public Stack(Node node)
        {
            Top = node;
        }

        //Peek
        public Node Peek()
        {
            // this is a great place for a try/catch (if you want)
            return Top;
        }

        //Pop
        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            Size -= 1;
            return temp;
        }
        
        //Push
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
            Size += 1;
        }

        //Define Size
    }
}   