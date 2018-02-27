using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    /// <summary>
    /// 插入排序
    /// </summary>
    class InsertionSort:SortMethod
    {
        public int[] Sort(int[] inputNumber)
        {
            for (int i = 0; i < inputNumber.Length; i++)
            {
                int temp = inputNumber[i];
                int j = i;
                while ((j > 0) && temp < inputNumber[j - 1])
                {
                    inputNumber[j] = inputNumber[j - 1];
                    inputNumber[j - 1] = temp;
                    --j;
                }
                PublicMethod.showSortEveryTurn(inputNumber, i,"Insertion Sort");
            }
            return inputNumber;
        }
    }
}
