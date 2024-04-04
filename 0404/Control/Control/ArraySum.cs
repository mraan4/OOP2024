using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class ArraySum
    {
        static void Main(string[] args)
        {
            int[] number = new int[100];

            int i, sum = 0, count = 0;
            double average;

            for(i = 0; i < number.Length; i++)
            {
                Console.Write("(종료는 0 : number[" + i + "] = ");
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] == 0)
                    break;
                sum += number[i];
                count++;
            }
            average = (double)sum / count;
            Console.WriteLine("합은 = {0:D} 평균 = {1:F2}", sum, average);
        }
    }
}
