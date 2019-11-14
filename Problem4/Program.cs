using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4__Prep
{
    //Write a program, which finds the maximal sequence of consecutive
    //equal elements in an array.E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,1,2,3,2,2,2,1 };
            MaximalSequenceOfConsecutiveEqualElements(arr,arr.Length);
        }
        static void MaximalSequenceOfConsecutiveEqualElements(int[] arr,int length)
        {
            int count = 0;
            int bestCount = 0;
            int bestEndIndex = 0;
            for (int i = 1; i < length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestEndIndex = i;
                    }
                    
                }
                else
                {
                    count = 1;
                }
            }
            int[] bestConsecutiveSeq = new int[bestCount];
            for (int i = 0; i < bestConsecutiveSeq.Length; i++)
            {
                bestConsecutiveSeq[i] = arr[bestEndIndex];
            }
        }
    }
}
