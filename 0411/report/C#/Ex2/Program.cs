using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        public class TV
        {
            private int size;

            public TV(int size)
            {
                this.size = size;
            }

            protected int GetSize()
            {
                return size;
            }
        }

        public class ColorTV : TV
        {
            private int color;

            public ColorTV(int size, int color) : base(size)
            {
                this.color = color;
            }

            protected int GetColor()
            {
                return color;
            }
        }

        public class IPTV : ColorTV
        {
            private string address;

            public IPTV(string address, int size, int color) : base(size, color)
            {
                this.address = address;
            }

            public void PrintProperty()
            {
                Console.WriteLine("나의 IPTV는 " + address + " " + GetSize() + " 인치 " + GetColor() + " 컬러");
            }
        }
        static void Main(string[] args)
        {
            IPTV myTV = new IPTV("192.1.1.2", 32, 1024);
            myTV.PrintProperty();
        }
    }
}
