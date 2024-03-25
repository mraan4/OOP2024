using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exfive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1, side2, side3;

            Console.WriteLine("정수 3개를 입력>>");
            side1 = Convert.ToInt32(Console.ReadLine());
            side2 = Convert.ToInt32(Console.ReadLine());
            side3 = Convert.ToInt32(Console.ReadLine());

            if ((side1 + side2) < side3 || (side1 + side3) < side2 || (side2 + side3) < side1)
            {
                Console.WriteLine("삼각형을 만들 수 없습니다.");
            }
            else
            {
                Console.WriteLine("삼각형이 됩니다.");
            }
        }
    }
}
