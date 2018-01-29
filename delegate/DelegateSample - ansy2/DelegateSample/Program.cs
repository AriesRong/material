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
            //BeginInvoke立即返回而不等待异步调用完成（这就解释了上面的原因）
            //但是会返回一个用于监控异步调用进度的IAsyncResult
            IAsyncResult result = _sample.BeginInvoke(null, null);
            while (result.IsCompleted)
            {
                //可以监控异步方法执行是否完成
                //do task
            }
            //EndInvoke方法检索异步调用的结果
            //在调用 BeginInvoke 之后随时可以调用该方法
            //如果异步调用尚未完成，则 EndInvoke 会一直阻止调用线程，直到异步调用完成
            _sample.EndInvoke(result);
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
