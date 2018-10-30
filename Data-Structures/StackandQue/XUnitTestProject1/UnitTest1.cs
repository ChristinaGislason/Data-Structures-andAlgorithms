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

        // peek top node
        // return value from new top node

        // test peeking top node of stack
        // test enqueue node onto queue
        // test dequeue node off queue
        // test peek at front of queue

    }
}
