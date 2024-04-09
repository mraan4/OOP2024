using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        class Rectangle
        {
            private int x;
            private int y;
            private int width;
            private int height;

            public Rectangle(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }

            public void Show()
            {
                Console.WriteLine("(" + x + "," + y + ")에서 크기가 " + width + "x" + height + "인 사각형");
            }

            public int Square()
            {
                return width * height;
            }

            public bool Contains(Rectangle r)
            {
                if (x < r.x && y < r.y)
                {
                    if ((width + x) > (r.x + r.width) && (height + y) > (r.y + r.height))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 2, 8, 7);
            Rectangle s = new Rectangle(5, 5, 6, 6);
            Rectangle t = new Rectangle(1, 1, 10, 10);

            r.Show();
            Console.WriteLine("s의 면적은 " + s.Square());
            if (t.Contains(r)) Console.WriteLine("t는 r을 포함합니다.");
            if (t.Contains(s)) Console.WriteLine("t는 s를 포함합니다.");
        }
    }
}
