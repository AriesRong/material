using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateSample
{
    
    public delegate void delSample();
    class Program
    {
        static void Main(string[] args)
        {
            delSample _sample = DoTask;
            //BeingInvoke方法启动异步委托
            IAsyncResult result = _sample.BeginInvoke(null, null);
            //等待1s，执行主线程
            result.AsyncWaitHandle.WaitOne(1, false);           
            Console.WriteLine("do another work.");
            _sample.EndInvoke(result);
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
