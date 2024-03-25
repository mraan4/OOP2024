using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEight
{
    internal class Program
    {
        public static bool InRect(int x, int y, int rectX1, int rectY1, int rectX2, int rectY2)
        {
            if (x >= rectX1 && x <= rectX2 && y >= rectY1 && y <= rectY2)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("두점 (x,y)의 좌표를 입력하시오>>");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            if (InRect(x1, y1, 100, 100, 200, 200) || InRect(x2, y2, 100, 100, 200, 200))
                Console.WriteLine("충돌합니다");
            else
                Console.WriteLine("충돌 안 합니다.");

        }
    }
}
