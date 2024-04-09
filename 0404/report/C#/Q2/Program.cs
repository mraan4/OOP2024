using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        class Grade
        {
            private int math;
            private int science;
            private int english;

            public Grade(int math, int science, int english)
            {
                this.math = math;
                this.science = science;
                this.english = english;
            }

            public int Average()
            {
                return (math + science + english) / 3;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("수학, 과학, 영어 순으로 3개의 정수 입력 : ");
            int math = int.Parse(Console.ReadLine());
            int science = int.Parse(Console.ReadLine());
            int english = int.Parse(Console.ReadLine());

            Grade me = new Grade(math, science, english);
            Console.WriteLine("평균은 : " + me.Average());
        }
    }
}
