using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = (int)(new Random().NextDouble() * 10 + 1);
            }

            Console.Write("랜덤한 정수들 : ");
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " ");
                total += numbers[i];
            }
            Console.WriteLine("\n평균은 " + total / 10);
        }
    }
}
