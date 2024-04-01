using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("곱하고자 하는 두 수 입력>>");
                try
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num1 + "x" + num2 + "=" + num1 * num2);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("실수는 입력하면 안됩니다.");
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}
