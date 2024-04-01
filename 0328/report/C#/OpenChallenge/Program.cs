using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num;
            string ans;

            while (true)
            {
                Console.WriteLine("수를 결정하였습니다. 맞추어 보세요\n0~99");
                int i = 1;
                num = random.Next(0, 100);
                Console.WriteLine(num);

                while (true)
                {
                    Console.Write(i + ">>");
                    int user = Convert.ToInt32(Console.ReadLine());

                    if (user > num)
                    {
                        Console.WriteLine("더 낮게.");
                    }
                    else if (user < num)
                    {
                        Console.WriteLine("더 높게.");
                    }
                    else
                    {
                        Console.WriteLine("맞았습니다.");
                        Console.WriteLine("다시하시겠습니까(y/n)>>");
                        ans = Console.ReadLine();
                        if (ans.Equals("y"))
                        {
                            break;
                        }
                        else if (ans.Equals("n"))
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
