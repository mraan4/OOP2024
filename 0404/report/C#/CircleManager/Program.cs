using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleManager
{
    internal class Program
    {
        class Circle
        {
            private double centerX, centerY;
            private int radius;

            public Circle(double centerX, double centerY, int radius)
            {
                this.centerX = centerX;
                this.centerY = centerY;
                this.radius = radius;
            }

            public void Show()
            {
                Console.WriteLine("(" + centerX + "," + centerY + ")" + radius);
            }
        }


        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            for (int i = 0; i < circles.Length; i++)
            {
                Console.Write("X, Y, Radius >>");
                double centerX = Convert.ToDouble(Console.ReadLine());
                double centerY = Convert.ToDouble(Console.ReadLine());
                int radius = Convert.ToInt32(Console.ReadLine());
                circles[i] = new Circle(centerX, centerY, radius);
            }

            for (int i = 0; i < circles.Length; i++)
            {
                circles[i].Show();
            }
        }
    }
}
