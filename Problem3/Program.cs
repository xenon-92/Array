using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    //Fundamentals-of-Computer-Programming-with-CSharp-Nakov-eBook-v2013
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = {'a','a','b','c' };
            char[] arr2 = {'a','b','b' };
            char[] ret=CheckLeigrophicallyOfChars(arr1,arr2);
            Console.ReadKey();
        }
        static char[] CheckLeigrophicallyOfChars(char[] arr1,char[] arr2)
        {
            int minLength = arr1.Length >= arr2.Length ? arr2.Length : arr1.Length;
            int x = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i]>arr2[i])
                {
                    x=2;
                    break;
                }
                else if(arr1[i] < arr2[i])
                {
                    x=1;
                    break;
                }
            }
            char[] ret = x == 1 ? arr1 :   arr2;
            return ret;
        }
    }
}
