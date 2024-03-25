using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEleven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("달을 입력하세요(1~12)>>");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month >= 3 && month <= 5)
                Console.WriteLine("봄");
            else if (month >= 6 && month <= 8)
                Console.WriteLine("여름");
            else if (month >= 9 && month <= 11)
                Console.WriteLine("가을");
            else if (month == 12 || month == 1 || month == 2)
                Console.WriteLine("겨울");
            else
                Console.WriteLine("잘못된 만남이 아니고 입력");
        }
    }
}
