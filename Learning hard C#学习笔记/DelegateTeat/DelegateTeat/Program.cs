using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        //1.使用delegate关键字来定义一个委托类型
        delegate void MyDelegate(int para1, int para2);
        static void Main(string[] args)
        {
            //2.声明委托变量d
            MyDelegate d;
            //3.实例化委托类型，传递的方法也可以为静态方法，这里传递的是实例方法
            //d=new MyDelegate(obj.InstanceMethod)
            d = new MyDelegate(new Program().Add);
            //4.委托类型作为参数传递给另一个方法
            MyMethod(d);
            Console.Read();
        }

        //该方法的定义必须与委托定义相同，即返回类型为void，两个int类型的参数
        void Add(int para1,int para2)
        {
            int sum = para1 + para2;
            Console.WriteLine("the sum is:" + sum);
        }
        //方法的参数是委托类型
        private static void MyMethod(MyDelegate myDelegate)
        {
            //5.在方法中调用委托
            myDelegate(1, 2);
            //使用invoke方法显式地调用委托
            myDelegate.Invoke(3, 4);
        }
    }
}
