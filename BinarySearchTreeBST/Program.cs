﻿using System;

namespace BinarySearchTreeBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search!!!");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            binarySearch.AddNode(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.AddNode(68);
            binarySearch.display(binarySearch.root);
        }
    }
}
