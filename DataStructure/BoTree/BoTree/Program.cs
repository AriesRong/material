using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BoTree<Student> tree1 = new BoTree<Student>();
            tree1.Data = new Student("小波1", "男", 18);

            BoTree<Student> tree2 = new BoTree<Student>();
            tree2.Data = new Student("小波2", "男", 19);

            BoTree<Student> tree3 = new BoTree<Student>();
            tree3.Data = new Student("小波3", "男", 20);

            BoTree<Student> tree4 = new BoTree<Student>();
            tree4.Data = new Student("小波4", "男", 21);

            tree1.AddNode(tree2);
            tree1.AddNode(tree3);
            tree3.AddNode(tree4);

            Recursive(tree1);
            Console.ReadLine();
        }

        public static void Recursive(BoTree<Student> tree)
        {
            Console.WriteLine("姓名：{0}，性别：{1}，年龄：{2}", tree.Data.Name,tree.Data.Sex,tree.Data.Age);
            if (tree.Nodes.Count > 0)
            {
                foreach(var item in tree.Nodes)
                {
                    Recursive(item);
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public Student(string name,string sex,int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
    }

    

    public class BoTree<T>
    {
        private List<BoTree<T>> nodes;
        private BoTree<T> parent;
        public T Data { get; set; }
        public BoTree()
        {
            nodes = new List<BoTree<T>>();
        }
        public BoTree(T data)
        {
            this.Data = data;
            nodes = new List<BoTree<T>>();
        }
        /// <summary>
        /// 子结点
        /// </summary>
        public List<BoTree<T>> Nodes
        {
            get { return nodes; }
        }
        /// <summary>
        /// 父结点
        /// </summary>
        public BoTree<T> Parent
        {
            get { return parent; }
        }
        /// <summary>
        /// 添加结点
        /// </summary>
        /// <param name="node">结点</param>
        public void AddNode(BoTree<T> node)
        {
            if (!nodes.Contains(node))
            {
                node.parent = this;
                nodes.Add(node);
            }
        }
        /// <summary>
        /// 添加结点
        /// </summary>
        /// <param name="nodes">结点集合</param>
        public void AddNode(List<BoTree<T>> nodes)
        {
            foreach(var node in nodes)
            {
                if (!nodes.Contains(node))
                {
                    node.parent = this;
                    nodes.Add(node);
                }
            }
        }
        /// <summary>
        /// 移出结点
        /// </summary>
        /// <param name="node">结点</param>
        public void Remove(BoTree<T> node)
        {
            if (nodes.Contains(node))
                nodes.Remove(node);
        }
        public void RemoveAll()
        {
            nodes.Clear();
        }
    }
}
