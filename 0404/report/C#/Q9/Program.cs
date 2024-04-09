using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        class ArrayUtil
        {
            public static int[] Concat(int[] arrayA, int[] arrayB)
            {
                int[] resultArray = new int[arrayA.Length + arrayB.Length];
                int index = 0;
                for (; index < arrayA.Length; index++)
                {
                    resultArray[index] = arrayA[index];
                }
                for (; index < arrayA.Length + arrayB.Length; index++)
                {
                    resultArray[index] = arrayB[index - arrayA.Length];
                }
                return resultArray;
            }

            public static void Print(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(" " + array[i] + " ");
                }
                Console.Write("]");
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 5, 7, 9 };
            int[] array2 = { 3, 6, -1, 100, 77 };
            int[] array3 = ArrayUtil.Concat(array1, array2);
            ArrayUtil.Print(array3);
        }
    }
}
