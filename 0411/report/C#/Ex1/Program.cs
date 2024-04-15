using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        class TV
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

        class ColorTV : TV
        {
            private int color;

            public ColorTV(int size, int color) : base(size)
            {
                this.color = color;
            }

            public void PrintProperty()
            {
                Console.WriteLine(GetSize() + "인치 " + color + "컬러");
            }
        }
        static void Main(string[] args)
        {
            ColorTV myTV = new ColorTV(32, 1024);
            myTV.PrintProperty();
        }
    }
}
