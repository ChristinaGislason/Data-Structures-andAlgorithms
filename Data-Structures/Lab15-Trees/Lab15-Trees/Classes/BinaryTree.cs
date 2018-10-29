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

        public void Preorder()
        {
            int output = Root.Value;

            if(Root.leftChild != null)
            {
                output = Root.leftChild;
            }
            if (Root.rightChild != null)
            {
                output = Root.rightChild;
            }
        }

        public void Inorder()
        {

        }

        public void Postorder()
        {

        }

    }
}
