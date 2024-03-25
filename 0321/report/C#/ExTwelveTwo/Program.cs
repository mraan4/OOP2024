using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTwelveTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("연산>>");
            int op1 = Convert.ToInt32(Console.ReadLine());
            string op = Console.ReadLine();
            int op2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(op1 + "" + op + "" + op2 + "의 계산 결과는 " + (op1 + op2));
                    break;
                case "-":
                    Console.WriteLine(op1 + "" + op + "" + op2 + "의 계산 결과는 " + (op1 - op2));
                    break;
                case "*":
                    Console.WriteLine(op1 + "" + op + "" + op2 + "의 계산 결과는 " + (op1 * op2));
                    break;
                case "/":
                    if (op2 == 0)
                    {
                        Console.WriteLine("0으로 나눌 수 없습니다.");
                        break;
                    }
                    Console.WriteLine(op1 + "" + op + "" + op2 + "의 계산 결과는 " + (op1 / op2));
                    break;
            }
        }
    }
}
