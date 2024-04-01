using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unit = { 50000, 10000, 1000, 100, 10, 1 };

            Console.WriteLine("금액을 입력하시오>>");
            int money = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < unit.Length; i++)
            {
                Console.WriteLine(unit[i] + "원 짜리 : " + money / unit[i] + "개 ");
                money -= (money / unit[i]) * unit[i];
            }
        }
    }
}
