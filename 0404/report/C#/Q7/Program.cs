using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        class Day
        {
            private string work;
            public void Set(string work) { this.work = work; }
            public string Get() { return work; }
            public void Show()
            {
                if (work == null) Console.WriteLine("없습니다.");
                else Console.WriteLine(work + " 입니다.");
            }
        }

        public class MonthSchedule
        {
            private Day[] days;

            public MonthSchedule(int day)
            {
                this.days = new Day[day];
                for (int i = 0; i < days.Length; i++)
                {
                    days[i] = new Day();
                }
            }
            private void Input()
            {
                Console.Write("날짜(1~30)? ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("할일(빈칸없이입력)? ");
                string work = Convert.ToString(Console.ReadLine());
                day--;
                if (day < 0 || day > 30)
                {
                    Console.WriteLine("날짜를 잘못 입력하였습니다.");
                    return;
                }
                days[day].Set(work);
            }
            private void View()
            {
                Console.Write("날짜(1~30)? ");
                int day = Convert.ToInt32(Console.ReadLine());
                day--;
                if (day < 0 || day > 30)
                {
                    Console.WriteLine("날짜를 잘못 입력하였습니다.");
                    return;
                }
                Console.Write((day + 1) + "일의 할 일은 ");
                days[day].Show();
            }
            private void Finish()
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
            public void Run()
            {
                Console.Write("이번달 스케쥴 관리 프로그램.");
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Task (할일(입력:1, 보기:2, 끝내기:3) >>");
                    int select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1: Input(); break;
                        case 2: View(); break;
                        case 3: Finish(); return;
                    }
                }
            }
            static void Main(string[] args)
            {
                MonthSchedule april = new MonthSchedule(30);
                april.Run();
            }
        }
    }
}
