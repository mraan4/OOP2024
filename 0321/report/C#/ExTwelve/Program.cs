using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("연산>>");
            int op1 = Convert.ToInt32(Console.ReadLine());
            string op = Console.ReadLine();
            int op2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (op.Equals("+"))
                result = op1 + op2;
            else if (op.Equals("-"))
                result = op1 - op2;
            else if (op.Equals("*"))
                result = op1 * op2;
            else if (op.Equals("/"))
            {
                if (op2 == 0)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                    return;
                }
                else
                    result = op1 / op2;
            }
            else
            {
                Console.WriteLine("사칙연산이 아닙니다.");
                return;
            }
            Console.WriteLine(op1 + op + op2 + "의 계산 결과는 " + result);
        }
    }

}
