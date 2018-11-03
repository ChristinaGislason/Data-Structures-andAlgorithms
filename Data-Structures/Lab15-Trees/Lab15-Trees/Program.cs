using Lab15_Trees.Classes;
using System;
using System.Collections.Generic;

namespace Lab15_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate nodes          
            Node nodeD = new Node(25);
            Node nodeE = new Node(75);
            Node nodeF = new Node(150);
            Node nodeG = new Node(250);

            Node nodeC = new Node(200, nodeF, nodeG);
            Node nodeB = new Node(50, nodeD, nodeE);          
            Node nodeA = new Node(100, nodeB, nodeC);

            // add root node to binary tree
            BinaryTree binaryTree = new BinaryTree(nodeA);

            // write PreOrder list to console
            Console.WriteLine("PreOrder list:");
            List<Node> preorderList = binaryTree.PreOrder();
            foreach(Node node in preorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");

            // write InOrder list to console
            Console.WriteLine("InOrder list:");
            List<Node> inorderList = binaryTree.InOrder();
            foreach (Node node in inorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");

            // write PostOrder list to console
            Console.WriteLine("PostOrder list:");
            List<Node> postorderList = binaryTree.PostOrder();
            foreach (Node node in postorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");

            // instantiate new node
            Node node8 = new Node(333);

            // add new node to Binary Search Tree
            BinarySearchTree binarySearchTree = new BinarySearchTree(node8);

            // add new node to correct location in Binary Search Tree 
            binarySearchTree.AddToBST(node8);

            // construct a Binary Search Tree
            Node node1 = new Node(100);
            binarySearchTree.AddToBST(node1);
            Node node2 = new Node(50);
            binarySearchTree.AddToBST(node2);
            Node node3 = new Node(200);
            binarySearchTree.AddToBST(node3);
            Node node4 = new Node(25);
            binarySearchTree.AddToBST(node4);
            Node node5 = new Node(75);
            binarySearchTree.AddToBST(node5);
            Node node6 = new Node(150);
            binarySearchTree.AddToBST(node6);
            Node node7 = new Node(250);
            binarySearchTree.AddToBST(node7);
        
            // write BST PreOrder list to console
            Console.WriteLine("Binary Search Tree InOrder list:");
            List<Node> bstInorderList = binarySearchTree.InOrder();
            foreach (Node node in bstInorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");

        }
    }
}
