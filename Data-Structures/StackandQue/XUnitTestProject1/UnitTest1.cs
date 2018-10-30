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

        // test node popped from stack
        // test peeking top node of stack
        // test enqueue node onto queue
        // test dequeue node off queue
        // test peek at front of queue

    }
}
