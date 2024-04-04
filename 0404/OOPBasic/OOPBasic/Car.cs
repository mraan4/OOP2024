using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    internal class Car
    {
        public string color;
        public int speed;
        public void upSpeed(int value)
        {
            speed += value;
        }
        public void downSpeed(int value)
        {
            speed -= value;
        }
    }
}
