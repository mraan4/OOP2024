using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원의 중심과 반지름 입력:");
            double rx = Convert.ToDouble(Console.ReadLine());
            double ry = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("점 입력>>");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double dis = Math.Sqrt(((rx - x) * (rx - x)) + ((ry - y) * (ry - y)));
            if (dis <= r)
                Console.WriteLine("점" + x + "," + y + "은 원 안에 있습니다.");
            else
                Console.WriteLine("점" + x + "," + y + "은 원 밖에 있습니다.");
        }
    }
}
