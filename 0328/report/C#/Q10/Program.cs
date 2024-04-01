using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            int[] arr2 = new int[10];
            int x, y;

            for (int i = 0; i < 10; i++)
            {
                arr2[i] = (int)(new Random().NextDouble() * 10 + 1);
            }

            for (int i = 0; i < 10; i++)
            {
                x = (int)(new Random().NextDouble() * 4);
                y = (int)(new Random().NextDouble() * 4);
                if (matrix[x, y] == 0)
                {
                    matrix[x, y] = arr2[i];
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
