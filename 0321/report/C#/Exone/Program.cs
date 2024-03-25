using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원화를 입력하세요(단위 원) >> ");
            int won = Convert.ToInt32(Console.ReadLine());
            double result = won / 1100;
            Console.WriteLine(won + "원은 $" + result + "입니다.");
        }
    }
}
