using Challenge11_QueueWithStacks.Classes;
using System;
//using System.Collections.Generic;

namespace Challenge11_QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(new Node(1));
            // create nodes
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Dequeue();
        }

    }
}
