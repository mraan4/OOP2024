using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        abstract class Calc
        {
            protected int num1, num2;

            public void SetValues(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public abstract int Calculate();
        }

        class Add : Calc
        {
            public override int Calculate()
            {
                return num1 + num2;
            }
        }

        class Min : Calc
        {
            public override int Calculate()
            {
                return num1 - num2;
            }
        }

        class Mul : Calc
        {
            public override int Calculate()
            {
                return num1 * num2;
            }
        }

        class Sub : Calc
        {
            public override int Calculate()
            {
                return num1 / num2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("두 정수와 연산자를 입력하세요 >> ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            string op = Console.ReadLine();

            Calc cal;
            switch (op)
            {
                case "+":
                    cal = new Add();
                    break;
                case "-":
                    cal = new Min();
                    break;
                case "*":
                    cal = new Mul();
                    break;
                case "/":
                    cal = new Sub();
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    return;
            }
            cal.SetValues(num1, num2);
            Console.WriteLine(cal.Calculate());
        }
    }
}
