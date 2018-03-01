using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace childInitOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            childA child = new childA();
            child.Print();
            Console.Read();
        }
    }
    public class Parent
    {
        //2.调用基类构造函数
        public Parent()
        {
            Console.WriteLine("基类构造函数被调用");
        }
        public virtual void Print() { }

        public void Test() { }
    }

    // sealed 密封的，不再能被继承
    public sealed class childA : Parent
    {
        //创建一个childA对象时，
        //1.初始化它的实例字段
        private int fieldA = 3;

        //3.调用子类构造函数
        public childA()
        {
            Console.WriteLine("子类构造函数被调用");
        }

        public sealed override void Print()
        {
            Console.WriteLine(fieldA);
        }

        public new void  Test()
        {
            Console.WriteLine("派生类中定义了与基类成员同名的成员，可以用new关键字把基类成员隐藏起来");
        }
    }
}
