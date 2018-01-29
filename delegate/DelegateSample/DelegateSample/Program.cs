using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateSample
{
    //委托调用的是主线程，因此复杂的方法函数会导致主线程阻塞，影响用户体验
    public delegate void delSample();
    class Program
    {
        static void Main(string[] args)
        {
            delSample _sample = DoTask;
            _sample();
            Console.WriteLine("do another work.");
            Console.ReadKey();
        }

        public static void DoTask()
        {
            Console.WriteLine("start to do complicate work...");
            //线程阻塞5s，模拟进行复杂的工作。
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("work has done.");
        }
    }
}
