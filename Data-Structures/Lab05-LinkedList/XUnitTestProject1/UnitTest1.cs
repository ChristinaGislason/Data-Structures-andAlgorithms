using System;
using Xunit;
using Lab05_LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddingNodeToFront()
        {          
            Node node = new Node(10);
            LinkedList linkedList = new LinkedList(new Node(5));
            linkedList.Insert(node);
            Assert.Equal(10, linkedList.Head.Value);
        }
        
        //testing to add another node



    }
}
