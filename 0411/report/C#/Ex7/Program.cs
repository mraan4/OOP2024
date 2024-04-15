using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        class Point3D : Point
        {
            private int z;

            public Point3D(int x, int y, int z) : base(x, y)
            {
                this.z = z;
            }

            public void MoveUp()
            {
                this.z += 1;
            }

            public void MoveDown()
            {
                this.z -= 1;
            }

            public void SetXY(int x, int y)
            {
                base.Move(x, y);
            }

            public void Move(int x, int y, int z)
            {
                base.Move(x, y);
                this.z = z;
            }

            public override string ToString()
            {
                return "(" + GetX() + "," + GetY() + "," + z + ")의 점";
            }
        }

        static void Main(string[] args)
        {
            Point3D p = new Point3D(1, 2, 3);
            Console.WriteLine("초기 점의 위치는 " + p.ToString() + " 입니다.");
            p.MoveUp();
            Console.WriteLine("한 칸 위로 이동한 점은 " + p.ToString() + " 입니다.");
            p.MoveDown();
            Console.WriteLine("한 칸 아래로 이동한 점은 " + p.ToString() + " 입니다.");
            p.Move(10, 10);
            Console.WriteLine("x,y좌표가 이동한 점은 " + p.ToString() + " 입니다.");
            p.Move(100, 200, 300);
            Console.WriteLine("x,y,z좌표가 이동한 점은 " + p.ToString() + " 입니다.");
        }
    }
}
