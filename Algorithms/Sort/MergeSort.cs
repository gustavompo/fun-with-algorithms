using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public class MergeSort
    {
        public static void Sort(int[] arr)
        {
            DivideAndMerge(arr, 0, arr.Length - 1);
        }

        public static void DivideAndMerge(int[] arr, int iStart, int iEnd)
        {
            if (iEnd - iStart <= 1)
            {
                if (iEnd - iStart == 1)
                {
                    var merged = Merge(arr, iStart, iEnd, iEnd);
                    Array.Copy(merged, 0, arr, iStart, merged.Length);
                }
                return;
            }
            var middle = (int)(iEnd + iStart)/2;
            DivideAndMerge(arr, iStart, middle);
            DivideAndMerge(arr, middle, iEnd);
            var _merged = Merge(arr, iStart, middle, iEnd);
            Array.Copy(_merged, 0, arr, iStart, _merged.Length);
        }

        private static int[] Merge(int[] a, int iStart, int iCenter, int iEnd)
        {
            int iRunA = iStart,
                iRunB = iCenter;
            var result = new int[iEnd - iStart + 1];
            for (var iRun = 0; iRun < result.Length; iRun++)
            {
                if (iRunB > iEnd || (iRunA < iCenter && a[iRunA] <= a[iRunB]))
                {
                    result[iRun] = a[iRunA++];
                }
                else
                {
                    result[iRun] = a[iRunB++];
                }
            }
            return result;
        }
    }
}
