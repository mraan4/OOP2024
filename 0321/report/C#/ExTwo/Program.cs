using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2자리수 정수 입력(10~99)>>");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 10 == number / 10)
            {
                Console.Write("YES! 10의 자리와 1의 자리가 같습니다.");
            }
            else
            {
                Console.Write("NO 10의 자리와 1의 자리가 다릅니다.");
            }
        }
    }
}
