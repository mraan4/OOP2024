using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        class TV
        {
            private string brand;
            private int year;
            private int inch;

            public TV(string brand, int year, int inch)
            {
                this.brand = brand;
                this.year = year;
                this.inch = inch;
            }

            public void Show()
            {
                Console.WriteLine(brand + "에서 만든 " + year + "년형 " + inch + "인치 TV");
            }
        }
        static void Main(string[] args)
        {
            TV myTV = new TV("LG", 2017, 32);
            myTV.Show();
        }
    }
}
