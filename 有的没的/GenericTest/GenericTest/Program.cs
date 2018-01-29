using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringA = "I'm A.";
            string stringB = "I'm B.";
            Swap<string>(ref stringA, ref stringB);
            Console.WriteLine(stringA.ToString());

            int a = 19;
            int b = 13;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a.ToString());

            int i = Compare<string>(stringA, stringB);
            Console.WriteLine(i);

            IShape circle =new Circle(new Point(0,0),3);
            Console.WriteLine(circle.Area);

            var circles = new List<Circle>
            {
                new Circle(new Point(0,0),3),
                new Circle(new Point(0,0),4),
                new Circle(new Point(0,0),2),
            };

            //泛型的逆变：
            //AreaComparer可以比较任意图形的面积，但我们可以传入具体的图形例如圆或正方形
            //Compare方法签名：Compare(IShape x, IShape y)
            //IComparer<in T>支持逆变
            //传入的是圆形Circle，但要求的输入是IShape
            circles.Sort(new AreaComparer());
            foreach(Circle j in circles)
            {
                Console.WriteLine(j.Area);
            }

            Console.Read();
        }

        /// <summary>
        /// 交换两个同类型变量的值
        /// </summary>
        /// <typeparam name="T">同一种类型</typeparam>
        /// <param name="A"></param>
        /// <param name="B"></param>
        static void Swap<T>(ref T A, ref T B)
        {
            T temp;
            temp = A;
            A = B;
            B = temp;
        }

        static int Compare<T>(T O1, T O2) where T : IComparable<T>
        {
            return O1.CompareTo(O2);
        }

        
    }

    public interface IShape
    {
        double Area { get; }
    }
    public sealed class Circle : IShape
    {
        private readonly Point center;
        public Point Center { get { return center; } }

        private readonly double radius;
        public double Radius { get { return radius; } }

        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public double Area
        {
            get { return Math.PI * radius * radius; }
        }
    }
    public class AreaComparer : IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            return x.Area.CompareTo(y.Area);
        }
    }
}
