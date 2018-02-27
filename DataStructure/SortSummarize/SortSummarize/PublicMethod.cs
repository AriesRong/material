using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    public static class PublicMethod
    {
        /// <summary>
        /// 显示每一轮排序的结果
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <param name="i"></param>
        public static void showSortEveryTurn(int[] inputNumber,int i,string sortMethodName)
        {
            Console.Write("{0}排序，第{1}轮排序结果：", sortMethodName, i + 1);
            foreach (int m in inputNumber)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 在数组中交换两个数据
        /// </summary>
        /// <param name="A"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
