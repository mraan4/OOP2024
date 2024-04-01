using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { "Java", "C++", "HTML5", "컴퓨터구조", "안드로이드" };
            int[] scores = { 95, 88, 76, 62, 55 };
            Console.WriteLine("과목 이름(그만 입력시 종료)>>");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("그만"))
                {
                    Console.WriteLine("종료...");
                    break;
                }

                bool courseFound = false;

                for (int i = 0; i < courses.Length; i++)
                {
                    if (input.Equals(courses[i]))
                    {
                        Console.WriteLine(courses[i] + "의 점수는 " + scores[i]);
                        courseFound = true;
                        break;
                    }
                }

                if (!courseFound)
                {
                    Console.WriteLine("없는 과목입니다.");
                }
            }
        }
    }
}
