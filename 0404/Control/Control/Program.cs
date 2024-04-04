using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            while (true)
            {
                Console.Write("점수 입력(종료 : 0보다 작거나 100보다 큰 수) : ");
                score = int.Parse(Console.ReadLine());

                if (score < 0 || score > 100)
                    break;

                if (score >= 90)
                    Console.WriteLine("A 등급입니다.");
                else if (score >= 80)
                    Console.WriteLine("B 등급입니다.");
                else if (score >= 70)
                    Console.WriteLine("C 등급입니다.");
                else
                    Console.WriteLine("F 등급입니다.");
            }
        }
    }
}
