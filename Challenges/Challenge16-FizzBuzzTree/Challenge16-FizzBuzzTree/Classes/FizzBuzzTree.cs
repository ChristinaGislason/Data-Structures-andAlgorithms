using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge16_FizzBuzzTree.Classes
{
    class FizzBuzzTree
    {

        /// <summary>
        /// Points to the first/top node 
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Tree constructor that requires a node at time of creation to be the Root
        /// </summary>
        /// <param name="node">The node that will become the Root</param>
        public FizzBuzzTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        ///  Traverses FizzBuzz Tree in order of left, root, right.
        /// </summary>
        /// <param name="Root"></param>
        public List<Node> FizzBuzz(Node node = null, List<Node> nodes = null)
        {
            // Create list of nodes initially for first call to FizzBuzz()
            if(nodes == null)
            {
                nodes = new List<Node>();
            }

            // Set node to root for the first call to FizzBuzz()
            if(node == null)
            {
                node = Root;
            }

            // Update node value to FizzBuzz, Buzz, Fizz, or don't change
            if((int)(node.Value) % 15 == 0)
            {
                node.Value = "FizzBuzz";
            }
            else if((int)(node.Value) % 5 == 0)
            {
                node.Value = "Buzz";
            }
            else if((int)(node.Value) % 3 == 0)
            {
                node.Value = "Fizz";
            }


            // Traverse the tree and add node to list 
            if(node.leftChild != null)
            {
                FizzBuzz(node.leftChild, nodes);
            }

            nodes.Add(node);

            if(node.rightChild != null)
            {
                FizzBuzz(node.rightChild, nodes);
            }

            return nodes;
        }
    }
}
