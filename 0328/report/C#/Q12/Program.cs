using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            for (int index = 0; index < args.Length; index++)
            {
                try
                {
                    totalSum += int.Parse(args[index]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
