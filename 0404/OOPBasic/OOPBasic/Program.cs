using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Car1
    {
        public string name;
        public string color;
        public int speed;

        public Car1()
        {
            name = "붕붕"; color = "흰색"; speed = 0;
        }
        public Car1(string name, string color)
        {
            this.name = name; this.color = color; speed = 0;
        }

        public void speedUp(int value)
        {
            this.speed += value;
        }
        public void speedDown(int value)
        {
            this.speed -= value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.color = "빨강";
            myCar1.speed = 0;

            Car myCar2 = new Car();
            myCar2.color = "파랑";
            myCar2.speed = 0;

            Car myCar3 = new Car();
            myCar3.color = "노랑";
            myCar3.speed = 0;

            myCar1.upSpeed(10);
            Console.WriteLine("자동차1의 색상은 {0}이며, 현재 속도는 {1}km 입니다.", myCar1.color,myCar1.speed);

            Car1 yourCar = new Car1();
            Console.WriteLine("자동차1의 색상은 {0}이며, 현재 속도는 {1}km 입니다.", yourCar.color, yourCar.speed);
        }
    }
}
