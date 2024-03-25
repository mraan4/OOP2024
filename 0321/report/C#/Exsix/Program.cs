using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exsix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1~99 사이의 정수를 입력하시오>>");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num != 0 && num >= 1 && num <= 99)
            {
                int tensDigit, onesDigit;
                tensDigit = num / 10;
                onesDigit = num % 10;

                if ((tensDigit == 3 || tensDigit == 6 || tensDigit == 9) && (onesDigit == 3 || onesDigit == 6 || onesDigit == 9))
                {
                    Console.WriteLine("박수짝짝");
                }
                else if ((tensDigit == 3 || tensDigit == 6 || tensDigit == 9) || (onesDigit == 3 || onesDigit == 6 || onesDigit == 9))
                {
                    Console.WriteLine("박수짝");
                }
            }
            else
            {
                Console.WriteLine("숫자의 범위를 벗어났습니다.");
            }
        }
    }
}
