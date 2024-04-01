using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = new int[][] { new int[] { 1 }, new int[] { 1, 2, 3 }, new int[] { 1 },
                               new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 } };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
