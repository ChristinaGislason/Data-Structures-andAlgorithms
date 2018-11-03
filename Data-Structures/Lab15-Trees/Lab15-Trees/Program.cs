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
            Console.WriteLine("PreOrder List:");
            List<Node> preorderList = binaryTree.PreOrder();
            foreach(Node node in preorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");

            // write InOrder list to console
            Console.WriteLine("InOrder List:");
            List<Node> inorderList = binaryTree.InOrder();
            foreach (Node node in inorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");

            // write PostOrder list to console
            Console.WriteLine("PostOrder List:");
            List<Node> postorderList = binaryTree.PostOrder();
            foreach (Node node in postorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("\n-----");
        }
    }
}
