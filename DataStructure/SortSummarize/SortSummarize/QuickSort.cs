using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSummarize
{
    /// <summary>
    /// 快速排序
    /// </summary>
    class QuickSort : SortMethod
    {
        public int turn = 0;
        public int[] Sort(int[] inputNumber)
        {
            quick_sort(inputNumber,0,inputNumber.Length-1);
            return inputNumber;
        }
        private void quick_sort(int[] inputNumber, int low, int high)
        {
            int middle = 0;
            PublicMethod.showSortEveryTurn(inputNumber, turn, "Quick Sort");
            turn++;
            if (low < high)
            {
                middle = partition(inputNumber, low, high);
                quick_sort(inputNumber, middle + 1, high);
                quick_sort(inputNumber, low, middle - 1);
            }
            
        }

        private int partition(int[] inputNumber,int low,int high)
        {
            int key = inputNumber[low];
            while (low < high)
            {
                while (high > low && inputNumber[high] >= key) high--;
                PublicMethod.Swap(inputNumber, low, high);
                key = inputNumber[high];
                while (high > low && inputNumber[low] < key) low++;
                PublicMethod.Swap(inputNumber, low, high);
                key = inputNumber[low];
                
            }
            return low;
        }
    }
}
