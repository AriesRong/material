using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    class BubbleSort : SortMethod
    {
        public int[] Sort(int[] inputNumber)
        {
            int j = 0;
            while (j < inputNumber.Length)
            {
                for (int i = 0; i < inputNumber.Length-1; i++)
                {

                    if (inputNumber[i] > inputNumber[i + 1])
                    {
                        PublicMethod.Swap(inputNumber, i, i + 1);
                    }
                }
                PublicMethod.showSortEveryTurn(inputNumber, j, "Bubble Sort");
                j++;
            }
            return inputNumber;
        }
    }
}
