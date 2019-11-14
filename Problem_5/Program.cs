using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    //maximal sequence of consecutively
    //placed increasing integers.Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
            int[] arr1 = { 3, 3, 3, 4, 5, 6, 7 };
            int[] arr2 = { 1,2,4,8,7,11};
            //FindSequential(arr,arr.Length);
            //FindSequential(arr1,arr1.Length);
            FindSequential(arr2,arr2.Length);
        }
        static void FindSequential(int[] arr,int length)
        {
            int count = 0;int bestCount = 0;int lastIndex = -1;
            for (int i = 1; i < length; i++)
            {
                if (arr[i-1]==arr[i]-1)
                {
                    count++;
                    if (count>bestCount)
                    {
                        bestCount = count;
                        lastIndex = i;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            int[] arr1 = new int[bestCount];
            arr1[bestCount - 1] = arr[lastIndex];
        }
    }
}
