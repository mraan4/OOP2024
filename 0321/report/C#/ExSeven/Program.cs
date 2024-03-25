using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점 (x,y)의 좌표를 입력하시오 >>");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if ((100 <= x && x <= 200) && (100 <= y && y <= 200))
            {
                Console.Write("사각형 안에 점이 있습니다.");
            }
            else
            {
                Console.WriteLine("사각형 안에 점이 없습니다.");
            }

        }
    }
}
