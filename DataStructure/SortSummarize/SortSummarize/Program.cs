using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入需要排列的数组
            Console.WriteLine("Please input the numbers:");
            int[] inputNumber = getinputNumber(Console.ReadLine());
            intputString();
            //选择排列数组用的方法，并排序
            int choicedSortWay = Convert.ToInt32(Console.ReadLine());
            int[] sortedNumber = Sort(choicedSortWay, inputNumber);
            Console.WriteLine("The sorted number is:");
            foreach(int i in sortedNumber)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
        private static void intputString()
        {
            Console.WriteLine("Please choice a way for sorting:");
            Console.WriteLine("1.Insertion Sort");
            Console.WriteLine("2.Selection Sort");
            Console.WriteLine("3.Bubble Sort");
            Console.WriteLine("4.Quick Sort");
            Console.WriteLine("5.Shell Sort");
            Console.WriteLine("6.Merge Sort");
            Console.WriteLine("");
        }

        private static int[] Sort(int choicedWay, int[] inputNumber)
        {
            SortMethod sortMethod=null;
            switch (choicedWay)
            {
                case 1:
                    sortMethod = new InsertionSort();
                    break;
                case 2:
                    sortMethod= new SelestionSort();
                    break;
                case 3:
                    sortMethod = new BubbleSort();
                    break;
                case 4:
                    sortMethod = new QuickSort();
                    break;
                case 5:
                    sortMethod = new ShellSort();
                    break;
                case 6:
                    sortMethod = new MergeSort();
                    break;
                default:
                    sortMethod = null;
                    break;
            }
            return sortMethod.Sort(inputNumber);
        }
        /// <summary>
        /// 将输入的字符串转化成为数组（用空格分开）
        /// </summary>
        /// <param name="inputString">输入的字符串</param>
        /// <returns>数组</returns>
        private static int[] getinputNumber(string inputString)
        {
            string[] temp = inputString.Split(' ');
            int[] inputNumber = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                inputNumber[i] = Convert.ToInt32(temp[i]);
            }
            return inputNumber;
        }
        
    }
}
