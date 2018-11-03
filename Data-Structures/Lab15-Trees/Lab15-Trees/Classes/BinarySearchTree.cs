using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Trees.Classes
{
    class BinarySearchTree
    {
        /// <summary>
        /// Points to the first/top node 
        /// </summary>
        public Node Root { get; set; }
  
        /// <summary>
        /// Binary Search Tree constructor that requires a node at time of creation to be the Root
        /// </summary>
        /// <param name="node">The node that will become the Root</param>
        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Traverses Binary Search Tree in order to add new node in correct location 
        /// </summary>
        /// <param name="Root"></param>
        public void AddToBST(Node node, Node current = null)
        {
            // make current node Root for the first call to AddToBST
            if(current == null)
            {
                current = Root;
            }

            if(node.Value < current.Value)
            {
                // if left child is null, then insert node
                if (current.leftChild == null)
                {
                    current.leftChild = node;
                }
                else
                {
                    AddToBST(node, current.leftChild);
                }
            }

            if(node.Value > current.Value)
            {
                // if right child is null, then insert node
                if(current.rightChild == null)
                {
                    current.rightChild = node;
                }
                else
                {
                    AddToBST(node, current.rightChild);
                }
            }
        }

        /// <summary>
        ///  Traverses Binary Tree in order of left, root, right.
        /// </summary>
        /// <param name="Root"></param>
        public List<Node> InOrder(Node node = null, List<Node> nodes = null)
        {
            if(nodes == null)
            {
                nodes = new List<Node>();
            }

            if(node == null)
            {
                node = Root;
            }

            if(node.leftChild != null)
            {
                InOrder(node.leftChild, nodes);
            }

            nodes.Add(node);

            if(node.rightChild != null)
            {
                InOrder(node.rightChild, nodes);
            }

            return nodes;
        }
        
        // Search Binary Search Tree by input value and return the node
        public Node SearchBST(int value, Node current = null)
        {
            if(current == null)
            {
                current = Root;
            }

            if(value == current.Value)
            {
                return current;
            }

            if(value < current.Value)
            {
                return SearchBST(value, current.leftChild);
            }

            else
            {
                return SearchBST(value, current.rightChild);
            }
        }
    }
}
