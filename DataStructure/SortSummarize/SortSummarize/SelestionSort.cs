using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    /// <summary>
    /// 选择排序
    /// </summary>
    class SelestionSort:SortMethod
    {
        public int[] Sort(int[] inputNumber)
        {
            int[] sortedNumber = new int[inputNumber.Length];
            for (int i = 0; i < inputNumber.Length; i++)
            {
                int temp = inputNumber[i];
                int j = i;
                for (j = i + 1; j < inputNumber.Length; j++)
                {
                    if (inputNumber[i] > inputNumber[j])
                    {
                        PublicMethod.Swap(inputNumber, i, j);
                    }
                }
                PublicMethod.showSortEveryTurn(inputNumber, i,"Selection Sort");
            }

            return inputNumber;
        }
    }
}
