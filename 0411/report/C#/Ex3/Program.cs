using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        public abstract class Converter
        {
            protected double ratio;

            protected abstract double Convert(double src);
            protected abstract string GetSrcString();
            protected abstract string GetDestString();

            public void Run()
            {
                Console.WriteLine(GetSrcString() + "을 " + GetDestString() + "로 바꿉니다.");
                Console.Write(GetSrcString() + "을 입력하세요>> ");

                double val = Convert.ToDouble(GetSrcString());
                double res = Convert(val);

                Console.WriteLine("변환 결과: " + res + GetDestString() + "입니다");
            }
        }

        public class Won2Dollar : Converter
        {
            public Won2Dollar(int ratio)
            {
                this.ratio = ratio;
            }

            protected override double Convert(double src)
            {
                return src / ratio;
            }

            protected override string GetSrcString()
            {
                return "원";
            }

            protected override string GetDestString()
            {
                return "달러";
            }
        }
        static void Main(string[] args)
        {
            Won2Dollar toDollar = new Won2Dollar(1200);
            toDollar.Run();

        }
    }
}
