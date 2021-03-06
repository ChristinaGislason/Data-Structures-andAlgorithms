﻿using Challenge16_FizzBuzzTree.Classes;
using System;
using System.Collections.Generic;

namespace Challenge16_FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate nodes to create tree          
            Node nodeD = new Node(2);
            Node nodeC = new Node(15);
            Node nodeB = new Node(5, nodeD);
            Node nodeA = new Node(3, nodeB, nodeC);

            // Add root node to FizzBuzz tree
            FizzBuzzTree fizzbuzzTree = new FizzBuzzTree(nodeA);

            // Write InOrder list of node values to console
            Console.WriteLine("InOrder list of FizzBuzz Tree:");
            List<Node> fizzBuzzList = fizzbuzzTree.FizzBuzz();
            foreach (Node node in fizzBuzzList)
            {
                Console.Write($"{node.Value} ");
            }          
        }
    }
}
