using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        class PositivePoint : Point
        {
            public PositivePoint() : base(0, 0)
            {
            }

            public PositivePoint(int x, int y) : base(x, y)
            {
                if (x < 0)
                {
                    if (y < 0) { base.Move(0, 0); }
                    else { base.Move(0, y); }
                }
                else if (y < 0) { base.Move(x, 0); }
                else { base.Move(x, y); }
            }

            public override void Move(int x, int y)
            {
                if (x >= 0 && y >= 0) { base.Move(x, y); }
                else { }
            }

            public override string ToString()
            {
                return "(" + GetX() + "," + GetY() + ")의 점";
            }
        }


        static void Main(string[] args)
        {
            PositivePoint p = new PositivePoint();
            p.Move(10, 10);
            Console.WriteLine(p.ToString() + "입니다.");

            PositivePoint p1 = new PositivePoint(-5, 5);

            Console.WriteLine(p1.ToString() + "입니다.");

            PositivePoint p2 = new PositivePoint(-10, -10);

            Console.WriteLine(p2.ToString() + "입니다.");
        }
    }
}
