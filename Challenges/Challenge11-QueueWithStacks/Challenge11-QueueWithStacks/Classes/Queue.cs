using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge11_QueueWithStacks.Classes
{
    public class Queue
    {
        Stack stack1 = new Stack(new Node(null));
        Stack stack2 = new Stack(new Node(null));
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            stack1.Pop();
            stack2.Pop();
            Front = node;
            Rear = node;
            stack1.Push(node);
        }

        // Enqueue
        public void Enqueue(Node node)
        {
            stack1.Push(node);
            Rear = node;
        }
        // Peek
        public Node Peek()
        {
            Node temp = new Node(null);
            temp = Front;
            temp.Next = null;
            return temp;
        }
        // Dequeue
        public Node Dequeue()
        {
            if (stack1.Size == 0)
                throw new Exception("Queue is Empty");
            Node temp = new Node(null);
            //Pop all existing elements from stack1, push them onto stack2
            int stack1Count = stack1.Size;
            for (int i = 0; i < stack1Count; i++)
            {
                stack2.Push(stack1.Pop());
            }
            // Save head of our queue
            temp = stack2.Pop();

            int stack2Count = stack2.Size;
            //Pop all elements from stack2 and push them back onto stack1
            for (int i = 0; i < stack2Count; i++)
            {
                stack1.Push(stack2.Pop());
            }
            return temp;
        }
    }
    
}
