using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbericalConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberInDecimal = Convert.ToInt32( Console.ReadLine());
            ConvertToOctal(NumberInDecimal);
            Console.Read();
        }
        /// <summary>
        /// 十进制转换为八进制：利用栈stack的方法
        /// </summary>
        /// <param name="NumberInDecimal">传输进来的十进制原数据</param>
        private static void ConvertToOctal(int NumberInDecimal)
        {
            Stack<int> number = new Stack<int>();
            while (NumberInDecimal != 0)
            {
                number.Push(NumberInDecimal % 8);
                NumberInDecimal = NumberInDecimal / 8;
            }
            while (number.Count != 0)
            {
                int i = number.Pop();
                Console.Write(i);
            }
        }
    }
}
