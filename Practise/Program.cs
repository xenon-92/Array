using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,2,3,4,5,6,7,8,9,10 };
            int[] reversed = ReverseAnArray(arr1,arr1.Length);


            bool symtest1 = CheckForSymmetricity(new int[] { 1, 2, 3, 4, 3, 2, 1 },7);
            bool symtest2 = CheckForSymmetricity(new int[] { 5, 6, 7, 7, 6, 5 },6);
            bool symtest3 = CheckForSymmetricity(new int[] { 7, 8, 9, 10, 8, 7 },6);

            char[] Char1 = { 'a', 'a', 'b', 'c' };
            char[] Char2 = { 'a', 'b', 'b' };
            char[] lexographicallysmall = Problem3(Char1, Char2);

            int[] seq1 = { 1, 1, 2, 3, 2, 2, 2, 1 };
            int[] seq2 = { 9,9,9,9, 2, 3, 2, 2, 2, 1 };
            int[] seq3 = { 9,9,9,9, 2, 3,3,3,3,3,3, 2, 2, 2, 1 };
            int[] seqResult1 = Problem4(seq1, seq1.Length);
            int[] seqResult2 = Problem4(seq2, seq2.Length);
            int[] seqResult3 = Problem4(seq3, seq3.Length);
            Console.ReadKey();
        }
        static int[] ReverseAnArray(int[] arr, int length)
        {
            int[] reversed = new int[length];
            for (int i = 0; i < length; i++)
            {
                reversed[i] = arr[length - 1 - i];
            }
            return reversed;
        }
        static bool CheckForSymmetricity(int[] arr, int length)
        {
            bool isSymetric = false;
            for (int i = 0; i < length/2; i++)
            {
                if (arr[i]!=arr[length-1-i])
                {
                    isSymetric = false;
                    break;
                }
                isSymetric = true;
            }
            return isSymetric;
        }

        static char[] Problem3(char[] arr1,char[] arr2)
        {
            int minlength = arr1.Length >= arr2.Length ? arr2.Length : arr1.Length;
            int counter = 0;
            for (int i = 0; i < minlength; i++)
            {
                if (arr1[i]>arr2[i])
                {
                    counter = 2;
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    counter = 1;
                    break;
                }
            }
            char[] chronological = counter == 1 ? arr1 : arr2;
            return chronological;
        }

        static int[] Problem4(int[] arr, int length)
        {
            int count = 1;
            int bestCount = 0;
            int bestEndIndex = 0;
            for (int i = 1; i < length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    count++;
                    if (count>bestCount)
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
            int[] seqEqualArr = new int[bestCount];
            for (int i = 0; i < seqEqualArr.Length; i++)
            {
                seqEqualArr[i] = arr[bestEndIndex];
            }
            return seqEqualArr;
        }
    }
}
