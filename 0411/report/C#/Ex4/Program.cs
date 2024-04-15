using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        abstract class Converter
        {
            protected double ratio;
            protected abstract double Convert(double src);
            protected abstract string GetSrcString();
            protected abstract string GetDestString();

            public void Run()
            {
                Console.WriteLine(GetSrcString() + "을 " + GetDestString() + "로 바꿉니다.");
                Console.Write(GetSrcString() + "을 입력하세요>> ");
                double val = Convert.ToDouble(Console.ReadLine());
                double res = Convert(val);
                Console.WriteLine("변환 결과: " + res + GetDestString() + "입니다");
            }
        }

        class Km2Mile : Converter
        {
            public Km2Mile(double ratio) { this.ratio = ratio; }

            protected override double Convert(double src)
            {
                return src / ratio;
            }

            protected override string GetSrcString()
            {
                return "Km";
            }

            protected override string GetDestString()
            {
                return "mile";
            }
        }
        static void Main(string[] args)
        {
            Km2Mile toMile = new Km2Mile(1.6);
            toMile.Run();
        }
    }
}
