using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class Three
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                if(i % 3 == 0)
                    sum += i;

            Console.WriteLine(sum);
        }
    }
}
