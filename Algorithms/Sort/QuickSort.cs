using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public class QuickSort
    {
        private static void Sort(int[] input, int lowerIndex, int upperIndex)
        {
            if (lowerIndex >= upperIndex)
            {
                return;
            }
            var pivotIndex = (int)((upperIndex - lowerIndex) / 2 + lowerIndex) ;
            var pivotValue = input[pivotIndex];
            Swap(input, pivotIndex, upperIndex);
            pivotIndex = lowerIndex;
            for (var i = lowerIndex; i < upperIndex; i++)
            {
                if (input[i] < pivotValue)
                {
                    Swap(input, i, pivotIndex);
                    pivotIndex++;
                }
            }
            Swap(input, pivotIndex, upperIndex);
            Sort(input, lowerIndex, pivotIndex - 1);
            Sort(input, pivotIndex + 1, upperIndex);
        }

        private static void Swap(int[] input, int a, int b)
        {
            var tmp = input[a];
            input[a] = input[b];
            input[b] = tmp;
        }

        public static void Sort(int[] input)
        {
            Sort(input, 0, input.Length-1);
        }
    }
}
