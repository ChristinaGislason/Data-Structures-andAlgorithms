using System;
using StackQueueDemo.Classes;

namespace StacksQueues
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instantiate nodes
            Node myNode1 = new Node(1);
            Node myNode2 = new Node(2);
            Node myNode3 = new Node(3);
            Node myNode4 = new Node(4);
            Node myNode5 = new Node(5);

            // add nodes to queue by using enqueue action
            Queue myQueue = new Queue(myNode1);
            myQueue.Enqueue(myNode2);
            myQueue.Enqueue(myNode3);
            myQueue.Enqueue(myNode4);
            myQueue.Enqueue(myNode5);

            //peek the nodes in the queue
            Console.WriteLine("Queue:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Peek #{i}: ");
                Console.WriteLine($"{myQueue.Peek().Value}");

                Node removedNode = myQueue.Dequeue();
                Console.WriteLine(removedNode.Value);
            }

            // add nodes to the stack
            Stack myStack = new Stack(myNode1);
            myStack.Push(myNode2);
            myStack.Push(myNode3);
            myStack.Push(myNode4);
            myStack.Push(myNode5);
            Console.WriteLine("==================");
            Console.WriteLine("Stack:");

            // peek, then pop nodes off the stack
            Console.WriteLine($"First peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Second peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Third peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Fourth peek: {myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"Fifth peek: {myStack.Peek().Value}");
            myStack.Pop();
            //Console.WriteLine($"Sixth peek: {myStack.Peek().Value}");
            //myStack.Pop();
        }
    }
}