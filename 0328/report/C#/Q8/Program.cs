using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 몇개?(1~99) : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = (int)(new Random().Next(1, 101));

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 10 == 9)
                {
                    Console.Write(numbers[i] + " ");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
