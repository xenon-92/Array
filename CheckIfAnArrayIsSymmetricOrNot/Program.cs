using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAnArrayIsSymmetricOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
            int[] arr1 = { 5, 6, 7, 7, 6, 5 };
            int[] arr2 = { 7, 8, 9, 10, 8, 7 };
            bool isSym = CheckForSymetricity(arr,arr.Length);
            bool isSym1 = CheckForSymetricity(arr1, arr1.Length);
            bool isSym2 = CheckForSymetricity(arr2, arr2.Length);
            Console.WriteLine(isSym +"  "+ isSym1+"  "+ isSym2);
            Console.ReadKey();
        }
        static bool CheckForSymetricity(int[] arr,int length)
        {
            bool isSymetric = false;
            for (int i = 0; i < length/2; i++)
            {
                if (arr[i]!=arr[length - 1-i])
                {
                    isSymetric = false;
                    break;
                }
                isSymetric = true;
            }
            return isSymetric;
        }
    }
}
