﻿using Lab15_Trees.Classes;
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

            Console.WriteLine("PreOrder List:");
            List<Node> preorderList = binaryTree.PreOrder();
            foreach(Node node in preorderList)
            {
                Console.Write($"{node.Value} ");
            }
            Console.WriteLine("-----");


            
            //
            //binaryTree.PreOrder();
            //Console.WriteLine();

            //binaryTree.InOrder(nodeA);

            //binaryTree.PostOrder(nodeA);
        }
    }
}
