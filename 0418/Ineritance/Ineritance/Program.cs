using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ineritance
{
    class Car
    {
        private string color;
        private int speed;
        internal Car()
        {
            this.speed = 0;
            this.color = "White";
        }
        internal Car(string color)
        {
            this.color = color;
        }
        internal Car(int speed)
        {
            this.speed = speed;
        }
        internal Car(string color, int speed)
        {
            this.speed=speed;
            this.color = color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public string getColor()
        {
            return this.color;
        }
        public void upSpeed(int speed)
        {
            this.speed += speed;
        }
        public void downSpeed(int speed)
        {
            this.speed -= speed;
        }
    }
    class Seden : Car
    {
        private int seatNum;
        internal Seden()
        {
            seatNum = 5;
        }
        internal void setSeatNum(int seatNum)
        {
            this.seatNum = seatNum;
        }
        internal int getSeatNum()
        {
            return this.seatNum;
        }
        public new void upSpeed(int speed)
        {
            int upSpeed = base.getSpeed();
            upSpeed += speed;
            if (upSpeed > 150)
                upSpeed = 150;
            base.setSpeed(upSpeed);
        }
        public new void downSpeed(int speed)
        {
            int downSpeed = base.getSpeed();
            downSpeed -= speed;
            if(downSpeed < 0)
                downSpeed = 0;
            base.setSpeed(downSpeed);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Seden seden1 = new Seden();
            seden1.setSpeed(30);
            seden1.setColor("Red");
            seden1.upSpeed(30);
            seden1.upSpeed(100);
            Console.WriteLine("자동차의 속도는 {0}km 색상은 {1} 좌석수는 {2}개 입니다.", seden1.getSpeed(), seden1.getColor(),seden1.getSeatNum());

        }
    }
}
