using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하시오>>");
            int n = Convert.ToInt32(Console.ReadLine());
            int t = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("*");
                }
                t--;
                Console.WriteLine();
            }
        }
    }
}
