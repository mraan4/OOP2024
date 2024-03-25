using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 원의 중심과 반지름 입력 >> ");
            int x = Convert.ToInt32(Console.ReadLine());
            int x1 = Convert.ToInt32(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("두 번째 원의 중심과 반지름 입력 >> ");
            int y = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            double r1 = Convert.ToDouble(Console.ReadLine());

            double distance = 0;
            distance = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));

            if (distance <= r + r1)
            {
                Console.WriteLine("두 원은 서로 겹친다.");
            }
            else
            {
                Console.WriteLine("두 원은 서로 안겹친다.");
            }
        }
    }
}
