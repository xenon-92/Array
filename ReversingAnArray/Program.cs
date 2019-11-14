using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            ReverseArray();
            ReversedArr();
            Reverse(arr,arr.Length);
        }
        static void ReverseArray()
        {
            int[] arr = {1,2,3,4,5,6,7 };
            int[] reversedArr = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length-1; i >=0; i--)
            {
                reversedArr[j] = arr[i];
                j++;
            }
        }
        static void ReversedArr()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int length = arr.Length;
            int[] reversedArr = new int[length];
            for (int i = 0; i < length; i++)
            {
                reversedArr[length - i - 1] = arr[i];
            }
        }
        static void Reverse(int[] arr,int length)
        {
            int[] arrRev = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrRev[length - 1 - i] = arr[i];
            }
        }
    }
}
