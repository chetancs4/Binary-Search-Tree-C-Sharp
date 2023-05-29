namespace BinarySearchTree
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int item)
        {
            Data = item;
            Left = Right = null;
        }
    }
}
