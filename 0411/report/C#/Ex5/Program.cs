using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        public class Point
        {
            private int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int GetX()
            {
                return x;
            }

            public void SetX(int x)
            {
                this.x = x;
            }

            public int GetY()
            {
                return y;
            }

            public void SetY(int y)
            {
                this.y = y;
            }

            protected void Move(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public class ColorPoint : Point
        {
            private string color;

            public ColorPoint(int x, int y, string color) : base(x, y)
            {
                this.color = color;
            }

            public void SetXY(int x, int y)
            {
                base.Move(x, y);
            }

            public string GetColor()
            {
                return color;
            }

            public void SetColor(string color)
            {
                this.color = color;
            }

            public override string ToString()
            {
                return GetColor() + "색의 , (" + GetX() + "," + GetY() + ")의 점";
            }
        }

        static void Main(string[] args)
        {
            ColorPoint cp = new ColorPoint(5, 5, "Yellow");
            string str1 = cp.ToString();
            Console.WriteLine("처음 정의된 colorPoint는 " + str1 + "입니다.");
            cp.SetXY(10, 20);
            cp.SetColor("Red");
            string str2 = cp.ToString();
            Console.WriteLine("이동한 colorPoint는 " + str2 + "입니다.");
        }
    }
}
