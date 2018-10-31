using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Trees.Classes
{
    class BinaryTree
    {
        /// <summary>
        /// Points to the first/top node 
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Binary Trees requires a node at time of creation to be the Root
        /// </summary>
        /// <param name="node">The node that will become the Root</param>
        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Traverses Binary Tree in order of root, left, right.
        /// </summary>
        /// <param name="Root"></param>
        public void PreOrder(Node Root)
        {
            object output = Root.Value;

            if(Root.leftChild != null)
            {
                PreOrder(Root.leftChild);
            }
            else if(Root.rightChild != null)
            {
                PreOrder(Root.rightChild);
            }
        }

        /// <summary>
        ///  Traverses Binary Tree in order of left, root, right.
        /// </summary>
        /// <param name="Root"></param>
        public void InOrder(Node Root)
        {        
            if (Root.leftChild != null)
            {
                InOrder(Root.leftChild);
            }

            object output = Root.Value;

            if (Root.rightChild != null)
            {
                InOrder(Root.rightChild);
            }
            
        }

        /// <summary>
        ///  Traverses Binary Tree in order of left, right, root.
        /// </summary>
        /// <param name="Root"></param>
        public void PostOrder(Node Root)
        {
            if (Root.leftChild != null)
            {
                PostOrder(Root.leftChild);
            }
            else if (Root.rightChild != null)
            {
                PostOrder(Root.rightChild);
            }

            object output = Root.Value;
        }

    }
}
