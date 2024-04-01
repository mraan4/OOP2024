using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("소문자 알파벳 하나를 입력하시오 >> ");
            string input = Console.ReadLine();
            char letter = input[0];

            for (int i = 0; i <= letter - 'a'; i++)
            {
                for (char j = 'a'; j <= letter - i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
