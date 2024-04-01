using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                int clapCount = 0;

                if (i % 10 == 3 || i % 10 == 6 || i % 10 == 9)
                {
                    clapCount += 1;
                }
                if (i / 10 == 3 || i / 10 == 6 || i / 10 == 9)
                {
                    clapCount += 1;
                }

                if (clapCount == 1)
                {
                    Console.WriteLine(i + " 박수 짝");
                }
                else if (clapCount == 2)
                {
                    Console.WriteLine(i + " 박수 짝짝");
                }
            }
        }
    }
}
