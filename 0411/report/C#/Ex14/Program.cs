using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class Program
    {
        interface IShape
        {
            const double PI = 3.14;

            void Draw();

            double GetArea();

            public void Redraw()
            {
                Console.WriteLine("=== 다시 그립니다. ===");
                Draw();
            }
        }

        class Circle : IShape
        {
            private int radius;

            public Circle(int radius)
            {
                this.radius = radius;
            }

            public void Draw()
            {
                Console.WriteLine("=== 도형을 그립니다. ===");
                Console.WriteLine("반지름이 " + radius + "인 원입니다.");
            }

            public double GetArea()
            {
                return radius * radius * IShape.PI;
            }
        }

        class Oval : IShape
        {
            private int width, height;

            public Oval(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public void Draw()
            {
                Console.WriteLine("=== 도형을 그립니다. ===");
                Console.WriteLine("가로 " + width + ", 세로 " + height + "에 내접하는 타원입니다.");
            }

            public double GetArea()
            {
                return width * height * IShape.PI;
            }
        }

        class Rect : IShape
        {
            private int width, height;

            public Rect(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public void Draw()
            {
                Console.WriteLine("=== 도형을 그립니다. ===");
                Console.WriteLine("가로 " + width + ", 세로 " + height + "인 사각형입니다.");
            }

            public double GetArea()
            {
                return width * height;
            }
        }

        static void Main(string[] args)
        {
            IShape[] list = new IShape[3];
            list[0] = new Circle(10);
            list[1] = new Oval(20, 30);
            list[2] = new Rect(10, 40);

            foreach (IShape shape in list)
            {
                shape.Draw();
                Console.WriteLine("면적은 " + shape.GetArea());
            }
        }
    }
}
