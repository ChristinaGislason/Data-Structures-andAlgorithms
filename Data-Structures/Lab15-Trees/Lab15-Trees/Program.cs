using Lab15_Trees.Classes;
using System;

namespace Lab15_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate nodes
            Node nodeA = new Node(100);
            Node nodeB = new Node(50);
            Node nodeC = new Node(200);
            Node nodeD = new Node(25);
            Node nodeE = new Node(75);
            Node nodeF = new Node(150);

            // add root node to binary tree
            BinaryTree binaryTree = new BinaryTree(nodeA);

            //
            binaryTree.PreOrder(nodeA);
            Console.WriteLine($"Binary Tree in PreOrder: {node Value});

            binaryTree.InOrder(nodeA);

            binaryTree.PostOrder(nodeA);
        }
    }
}
