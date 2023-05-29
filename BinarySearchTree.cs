namespace BinarySearchTree
{

    using System;

    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            root = InsertNode(root, data);
        }

        private Node InsertNode(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Data)
                root.Left = InsertNode(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertNode(root.Right, data);

            return root;
        }

        public void InOrderTraversal()
        {
            InOrder(root);
        }

        private void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.Write(root.Data + " ");
                InOrder(root.Right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrder(root);
        }

        private void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        public void PostOrderTraversal()
        {
            PostOrder(root);
        }

        private void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        public bool Search(int key)
        {
            return SearchNode(root, key);
        }

        private bool SearchNode(Node root, int key)
        {
            if (root == null)
                return false;

            if (root.Data == key)
                return true;

            if (key < root.Data)
                return SearchNode(root.Left, key);

            return SearchNode(root.Right, key);
        }
    }
}
