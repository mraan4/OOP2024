using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("정수를 입력하세요 >> ");
            num = int.Parse(Console.ReadLine());

            if(num % 3 == 0 || num % 5 == 0)
                Console.WriteLine(num + "은 3의 배수이거나 5의 배수입니다.");
            else
                Console.WriteLine(num + "은 3의 배수이거나 5의 배수가 아닙니다.");
        }
    }
}
