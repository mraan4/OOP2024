using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[10];
            Console.WriteLine("양의 정수 10개를 입력하시오>>");
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("3의 배수는: ");
            for (int j = 0; j < myArr.Length; j++)
            {
                if (myArr[j] % 3 == 0)
                    Console.Write(myArr[j] + " ");
            }
        }
    }
}
