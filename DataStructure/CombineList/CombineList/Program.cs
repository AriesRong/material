using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> LA = new List<int> { 0, 3, 5, 7, 9 };
            List<int> LB = new List<int> { 0, 2, 4, 6, 7, 9 ,12,24};
            List<int> LC = MergeList(LA, LB);
            
            foreach (int k in LC)
                Console.Write(k + ", ");

            Console.Read();
        }
        /// <summary>
        /// 合并两个非递减有序排列
        /// </summary>
        /// <param name="LA">非递减有序数列</param>
        /// <param name="LB">非递减有序数列</param>
        /// <returns></returns>
        private static List<int> MergeList(List<int> LA,List<int> LB)
        {
            List<int> LC = new List<int>();
            int i = 0, j = 0, numberInLA = 0, numberInLB = 0;
            while (i < LA.Count && j < LB.Count)
            {

                numberInLA = LA[i];
                numberInLB = LB[j];
                if (numberInLA < numberInLB)
                {
                    LC.Add(numberInLA); i++;
                }
                else if (numberInLB < numberInLA)
                {
                    LC.Add(numberInLB); j++;
                }
                else
                {
                    LC.Add(numberInLA); i++; j++;
                }
            }
            while (i < LA.Count)
            {
                numberInLA = LA[i];
                LC.Add(numberInLA);
                i++;
            }
            while (j < LB.Count)
            {
                numberInLB = LB[j];
                LC.Add(numberInLB);
                j++;
            }

            return LC;
        }
    }
}
