using StackQueueDemo.Classes;
using StacksQueues;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// test pushing node on to stack
        /// </summary>        
        [Fact]
        public void TestPushNodeToStack()
        {
            Node testNode = new Node(1);
            Stack testStack = new Stack(testNode);
            testStack.Push(testNode);
            Node testVar = testStack.Peek();
            Assert.Equal(1, testVar.Value);
        }

        /// <summary>
        /// test node popped from stack
        /// </summary>        
        [Fact]
        public void TestPopNodeFromStack()
        {
            Node testNode1 = new Node(5);
            Node testNode2 = new Node(10);
            Stack testStack = new Stack(testNode1);
            testStack.Push(testNode1);
            testStack.Push(testNode2);
            testStack.Pop();
            Node testVar = testStack.Peek();
            Assert.Equal(5, testVar.Value);
        }

        /// <summary>
        /// test to peek top node of stack
        /// </summary>        
        [Fact]
        public void TestPeekTopNodeOfStack()
        {
            Node testNode = new Node(5);
            Stack testStack = new Stack(testNode);
            testStack.Push(testNode);
            testStack.Peek();
            Node testVar = testStack.Peek();
            Assert.Equal(5, testVar.Value);
        }

        /// <summary>
        /// test to enqueue node onto queue
        /// </summary>        
        [Fact]
        public void TestEnqueueNodeToQueue()
        {
            Node testNode1 = new Node(5);
            Node testNode2 = new Node(10);
            Queue testQueue = new Queue(testNode1);
            testQueue.Enqueue(testNode1);
            testQueue.Enqueue(testNode2);
            Node testVar = testQueue.Peek();
            Assert.Equal(5, testVar.Value);
        }

        /// <summary>
        /// test to dequeue node off queue
        /// </summary>        
        [Fact]
        public void TestDequeueNodeOffQueue()
        {
            Node testNode1 = new Node(5);
            Node testNode2 = new Node(10);
            Queue testQueue = new Queue(testNode1);
            testQueue.Enqueue(testNode1);
            testQueue.Enqueue(testNode2);
            testQueue.Dequeue();
            Node testVar = testQueue.Peek();
            Assert.Equal(10, testVar.Value);
        }

        /// <summary>
        /// test to dequeue node off queue
        /// </summary>        
        [Fact]
        public void TestPeekAtFrontOfQueue()
        {
            Node testNode1 = new Node(5);
            Queue testQueue = new Queue(testNode1);
            testQueue.Enqueue(testNode1);
            Node testVar = testQueue.Peek();
            Assert.Equal(5, testVar.Value);
        }
    }
}
