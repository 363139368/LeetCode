using System;

namespace LeetCode
{
    internal class MyTree
    {
    }


    public class MyAvlTree
    {
    }


    public class AVLTreeNode<T> where T : IComparable
    {
        public AVLTreeNode(T value)
        {
            Value = value;
            Height = 1;
        }

        public T Value { get; set; }
        public AVLTreeNode<T> Left { get; set; }
        public AVLTreeNode<T> Right { get; set; }
        public int Height { get; set; }
    }

    public class AVLTree<T> where T : IComparable
    {
        private AVLTreeNode<T> root;

        // Get the height of the node
        private int Height(AVLTreeNode<T> node)
        {
            return node?.Height ?? 0;
        }

        // Right rotate
        private AVLTreeNode<T> RightRotate(AVLTreeNode<T> y)
        {
            var x = y.Left;
            var T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

            return x;
        }

        // Left rotate
        private AVLTreeNode<T> LeftRotate(AVLTreeNode<T> x)
        {
            var y = x.Right;
            var T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

            return y;
        }

        // Get balance factor of node
        private int GetBalance(AVLTreeNode<T> node)
        {
            return node == null ? 0 : Height(node.Left) - Height(node.Right);
        }

        // Insert a node
        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        private AVLTreeNode<T> Insert(AVLTreeNode<T> node, T value)
        {
            if (node == null)
                return new AVLTreeNode<T>(value);

            var compare = value.CompareTo(node.Value);
            if (compare < 0)
                node.Left = Insert(node.Left, value);
            else if (compare > 0)
                node.Right = Insert(node.Right, value);
            else
                return node;

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

            var balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && value.CompareTo(node.Left.Value) < 0)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && value.CompareTo(node.Right.Value) > 0)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && value.CompareTo(node.Left.Value) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && value.CompareTo(node.Right.Value) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        // Print the tree
        public void Print()
        {
            Print(root, "", true);
        }

        private void Print(AVLTreeNode<T> node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "   ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|  ";
                }

                Console.WriteLine(node.Value);
                Print(node.Left, indent, false);
                Print(node.Right, indent, true);
            }
        }
    }

    //AVLTree<int> tree = new AVLTree<int>();
    //tree.Insert(10);
    //tree.Insert(20);
    //tree.Insert(30);
    //tree.Insert(40);
    //tree.Insert(50);
    //tree.Insert(25);
    //tree.Print();
}