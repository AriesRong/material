using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMulticastDelegate
{
    public delegate void FeedBack(int num);
    class Program
    {
        static void Main(string[] args)
        {
            myMulticastDelegate program = new myMulticastDelegate();
            FeedBack FB1 = new FeedBack(program.instanceMethod);
            FeedBack FB2 = new FeedBack(myMulticastDelegate.staticMethod);
            FB1(2);
            FB2(2);

            FeedBack MulticastDelegate = null;
            MulticastDelegate += new FeedBack(program.instanceMethod);
            MulticastDelegate += new FeedBack(myMulticastDelegate.staticMethod);
            MulticastDelegate(2);

            MulticastDelegate -= new FeedBack(myMulticastDelegate.staticMethod);
            MulticastDelegate(2);

            //anonymous Methods
            Func<int, int> anon = delegate (int a)
               {
                   a = a + 1;
                   return a;
               };
            Console.WriteLine(anon(5));

            Action<int, int> anon2 = delegate (int i, int j)
               {
                   i = i + j;
                   Console.WriteLine(i);
               };
            anon2(2, 3);

            //Lambda
            Func<string, string> oneParam = s => s.Replace("a", "b");
            Console.WriteLine(oneParam("aabbccss"));

            Func<int, int, int> twoParam = (i, j) => (i * j);
            Console.WriteLine(twoParam(5, 3));

            Func<int, int, int> test = (i, j) =>
              {
                  i = i + 1;
                  j = i + j;
                  return j;
              };
            Console.WriteLine(test(3, 5));

            //closure
            int y = 5;
            Func<int, int> lambda = x => x + y;
            Console.WriteLine(lambda(2));
            y = 10;
            Console.WriteLine(lambda(2));

            Console.Read();
        }
    }

    class myMulticastDelegate
    {
        public void instanceMethod(int a)
        {
            Console.WriteLine(a.ToString());
        }
        public static void staticMethod(int b)
        {
            Console.WriteLine((b * b).ToString());
        }

    }

}
