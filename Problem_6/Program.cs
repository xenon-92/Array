using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    //WAP, which finds the maximal sequence of increasing
    //elements in an array arr[n]. It is not necessary the elements to be
    //consecutively placed.E.g.: { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            FindMaxSeq(arr,arr.Length);
        }
        static void FindMaxSeq(int[] arr,int length)
        {
            int count = 0;int bestCount = 0;int bestIndex = -1;
            for (int i = 0; i < length; i++)
            {   
                for (int j = i+1; j < length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestIndex = i;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            for (int i = bestIndex+1; i < length; i++)
            {
                if (arr[i-1]< arr[i] )
                {

                }
            }
            Console.WriteLine(bestIndex);
        }
    }
}
