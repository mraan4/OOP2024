using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Program
    {
        interface Shape
        {
            const double PI = 3.14;

            void draw();

            double getArea();

            public void redraw()
            {
                Console.WriteLine("=== 다시 그립니다. ===");
                draw();
            }
        }

        class Circle : Shape
        {
            private int radius;

            public Circle(int radius)
            {
                this.radius = radius;
            }

            public void draw()
            {
                Console.WriteLine("=== 도형을 그립니다. ===");
                Console.WriteLine("반지름이 " + radius + "인 원입니다.");
            }

            public double getArea()
            {
                return radius * radius * PI;
            }
        }

        static void Main(string[] args)
        {
            Shape dongle = new Circle(10);
            dongle.draw();
            Console.WriteLine("면적은 " + dongle.getArea());
        }
    }
}
