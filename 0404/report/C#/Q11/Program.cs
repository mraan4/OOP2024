using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    internal class Program
    {
        class Add
        {
            private int num1;
            private int num2;

            public void SetValue(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public int Calculate()
            {
                return num1 + num2;
            }
        }

        class Sub
        {
            private int num1;
            private int num2;

            public void SetValue(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public int Calculate()
            {
                return num1 - num2;
            }
        }

        class Mul
        {
            private int num1;
            private int num2;

            public void SetValue(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public int Calculate()
            {
                return num1 * num2;
            }
        }

        class Div
        {
            private int num1;
            private int num2;

            public void SetValue(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public int Calculate()
            {
                return num1 / num2;
            }
        }
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("두 정수와 연산자를 입력하시오 >> ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            char op = Console.ReadLine()[0];

            switch (op)
            {
                case '+':
                    Add add = new Add();
                    add.SetValue(num1, num2);
                    result = add.Calculate();
                    break;
                case '-':
                    Sub sub = new Sub();
                    sub.SetValue(num1, num2);
                    result = sub.Calculate();
                    break;
                case '*':
                    Mul mul = new Mul();
                    mul.SetValue(num1, num2);
                    result = mul.Calculate();
                    break;
                case '/':
                    Div div = new Div();
                    div.SetValue(num1, num2);
                    result = div.Calculate();
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
