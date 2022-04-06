using System;
using System.Collections.Generic;
using System.Text;

namespace _2static
{
    public static class Extention
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;

        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string smth)
        {
            foreach (var item in smth)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
       
        public static int[] GetValueIndexes(this string smth, char chr)
        {
            int[] arr = new int[0];
            for (int i = 0; i < smth.Length; i++)
            {
                if (smth[i] == chr)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }
    }
}
