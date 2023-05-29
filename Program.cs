namespace BinarySearchTree
{

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            // Inserting nodes
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            // Traversing the tree
            Console.WriteLine("InOrder Traversal:");
            bst.InOrderTraversal();
            Console.WriteLine();

            Console.WriteLine("PreOrder Traversal:");
            bst.PreOrderTraversal();
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            bst.PostOrderTraversal();
            Console.WriteLine();

            // Searching for a key
            int key = 40;
            if (bst.Search(key))
                Console.WriteLine(key + " found in the tree.");
            else
                Console.WriteLine(key + " not found in the tree.");
        }
    }
}
