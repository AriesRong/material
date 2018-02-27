using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    /// <summary>
    /// 希尔排序
    /// </summary>
    class ShellSort : SortMethod
    {
        public int[] Sort(int[] inputNumber)
        {
            int turn = 0;
            //增量h的初始值设定很关键
            for (int h = inputNumber.Length / 2 + 1; h > 0; h = h / 2)
            {
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    if (i + h < inputNumber.Length)
                    {
                        if (inputNumber[i] > inputNumber[i + h])
                        {
                            PublicMethod.Swap(inputNumber, i, i + h);
                        }
                    }
                   
                }
                PublicMethod.showSortEveryTurn(inputNumber, turn, "Shell Sort");
                turn++;
            }
            return inputNumber;
        }
    }
}
