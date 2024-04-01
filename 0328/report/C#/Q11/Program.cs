using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int index = 0; index < 3; index++)
            {
                total += int.Parse(args[index]);
            }

            Console.WriteLine(total / 3);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
