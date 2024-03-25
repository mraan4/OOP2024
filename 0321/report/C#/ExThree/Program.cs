using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("금액을 입력하세요>>");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("오만원권 " + amount / 50000 + "매");
            amount -= 50000 * (amount / 50000);
            Console.WriteLine("만원권 " + amount / 10000 + "매");
            amount -= 10000 * (amount / 10000);
            Console.WriteLine("천원권 " + amount / 1000 + "매");
            amount -= 1000 * (amount / 1000);
            Console.WriteLine("백원 " + amount / 100 + "개");
            amount -= 100 * (amount / 100);
            Console.WriteLine("오십원 " + amount / 50 + "개");
            amount -= 50 * (amount / 50);
            Console.WriteLine("십원 " + amount / 10 + "개");
            amount -= 10 * (amount / 10);
            Console.WriteLine("일원 " + amount + "개");
        }
    }
}
