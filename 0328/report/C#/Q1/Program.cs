using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Sum = 0;
            //int index = 0;
            //while (index < 100)
            //{
            //    Sum += index;
            //    index += 2;
            //}
            //Console.WriteLine(Sum);
            //int Sum = 0;
            //for (int index = 0; index < 100; index += 2)
            //{
            //    Sum += index;
            //}
            //Console.WriteLine(Sum);
            int Sum = 0;
            int num = 0;
            do
            {
                Sum += num;
                num += 2;
            } while (num < 100);

            Console.WriteLine(Sum);
        }
    }
}
