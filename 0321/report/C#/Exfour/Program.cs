using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exfour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 3개 입력>>");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                if (num2 < num3)
                {
                    Console.Write("중간 값은" + num2 + "입니다.");
                }
                else
                {
                    Console.Write("중간 값은" + num3 + "입니다.");
                }
            }
            else
            {
                if (num1 < num3)
                {
                    Console.Write("중간 값은" + num1 + "입니다.");
                }
                else
                {
                    Console.Write("중간 값은" + num3 + "입니다.");
                }
            }
        }
    }
}
