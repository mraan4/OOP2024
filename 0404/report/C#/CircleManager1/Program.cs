using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleManager1
{
    internal class Program
    {
        class Circle
        {
            private double X, Y;
            private int radius;

            public Circle(double X, double Y, int radius)
            {
                this.X = X;
                this.Y = Y;
                this.radius = radius;
            }

            public void Show()
            {
                Console.WriteLine("(" + X + "," + Y + ")" + radius);
            }

            public int GetRadius()
            {
                return radius;
            }
        }
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            int maxRadius = 0;

            for (int i = 0; i < circles.Length; i++)
            {
                Console.Write("X, Y, Radius >>");
                double X = Convert.ToDouble(Console.ReadLine());
                double Y = Convert.ToDouble(Console.ReadLine());
                int radius = Convert.ToInt32(Console.ReadLine());
                circles[i] = new Circle(X, Y, radius);
            }

            for (int i = 0; i < circles.Length; i++)
            {
                if (maxRadius < circles[i].GetRadius())
                    maxRadius = circles[i].GetRadius();
            }

            for (int i = 0; i < circles.Length; i++)
            {
                if (maxRadius == circles[i].GetRadius())
                {
                    Console.Write("가장 면적인 큰 원은 ");
                    circles[i].Show();
                }
            }
        }
    }
}
