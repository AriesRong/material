using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree= CreateFakeTree();
            PreOrder(tree);
            Console.WriteLine();
            InOrder(tree);
            Console.WriteLine();
            PostOrder(tree); 
            Console.Read();
        }
        public static Tree CreateFakeTree()
        {
            Tree tree = new Tree() { Value = "A" };
            tree.Left = new Tree()
            {
                Value = "B",
                Left = new Tree() { Value = "D", Left = new Tree() { Value = "G" } },
                Right = new Tree() { Value = "E", Right = new Tree() { Value = "H" } }
            };
            tree.Right = new Tree() { Value = "C", Right = new Tree() { Value = "F" } };
            return tree;
        }
        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="tree"></param>
        public static void PreOrder(Tree tree)
        {
            if (tree == null)
                return;

            System.Console.Write(tree.Value);
            PreOrder(tree.Left);
            PreOrder(tree.Right);
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="tree"></param>
        public static void InOrder(Tree tree)
        {
            if (tree == null)
                return;

            InOrder(tree.Left);
            System.Console.Write(tree.Value);
            InOrder(tree.Right);
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="tree"></param>
        public static void PostOrder(Tree tree)
        {
            if (tree == null)
                return;

            PostOrder(tree.Left);
            PostOrder(tree.Right);
            System.Console.Write(tree.Value);
        }
    }

    public class Tree
    {
        public string Value;
        public Tree Left;
        public Tree Right;
    }
}
