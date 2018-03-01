using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    /// <summary>
    /// 归并排序
    /// 申请空间，使其大小为两个已经排序序列之和，该空间用来存放合并后的序列
    /// </summary>
    class MergeSort : SortMethod
    {
        public int everyTurn = 0;
        public int[] Sort(int[] inputNumber)
        {
            mSort(inputNumber, 0, inputNumber.Length - 1);
            return inputNumber;
        }
        
        private void mSort(int[] inputNumber,int left,int right)
        {
            if (left >= right) return;
            int mid = (left + right) / 2;
            mSort(inputNumber, left, mid);
            mSort(inputNumber, mid + 1, right);
            merge(inputNumber, left, mid, right);
            PublicMethod.showSortEveryTurn(inputNumber, everyTurn, "Merge Sort");
            everyTurn++;
        }
        /// <summary>
        /// 合并两个有序数列
        /// </summary>
        /// <param name="inputNumber">包含了两个有序数列的数列</param>
        /// <param name="left">前一个有序数列初始位</param>
        /// <param name="mid">从中间断开前后两个有序数列</param>
        /// <param name="right">后一个有序数列的末尾</param>
        private void merge(int[] inputNumber, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
            {
                temp[k++] = (inputNumber[i] <= inputNumber[j]) ? inputNumber[i++] : inputNumber[j++];
            }
            while (i <= mid) temp[k++] = inputNumber[i++];
            while (j <= right) temp[k++] = inputNumber[j++];

            for (int p = 0; p < temp.Length; p++) inputNumber[left + p] = temp[p];
        }

    }
}
