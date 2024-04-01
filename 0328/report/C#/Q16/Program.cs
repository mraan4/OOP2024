using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("컴퓨터와 가위 바위 보 게임을 합니다.");
            int win = 0, lose = 0, draw = 0;

            while (true)
            {
                Console.WriteLine("가위 바위 보!>>");
                string user = Console.ReadLine();
                if (user.Equals("그만"))
                {
                    break;
                }
                int com = new Random().Next(1, 4);
                switch (com)
                {
                    case 1: // 가위라고 생각
                        if (user.Equals("가위"))
                        {
                            Console.WriteLine("사용자:가위, 컴퓨터:가위 비겼습니다.");
                            draw++;
                        }
                        else if (user.Equals("바위"))
                        {
                            Console.WriteLine("사용자:바위, 컴퓨터:가위 이겼습니다.");
                            win++;
                        }
                        else if (user.Equals("보"))
                        {
                            Console.WriteLine("사용자:보, 컴퓨터:가위 졌습니다.");
                            lose++;
                        }
                        else
                        {
                            Console.WriteLine("제대로 다시 입력하세요.");
                        }
                        break;
                    case 2: // 바위라고 생각
                        if (user.Equals("가위"))
                        {
                            Console.WriteLine("사용자:가위, 컴퓨터:바위 졌습니다.");
                            lose++;
                        }
                        else if (user.Equals("바위"))
                        {
                            Console.WriteLine("사용자:바위, 컴퓨터:바위 비겼습니다.");
                            draw++;
                        }
                        else if (user.Equals("보"))
                        {
                            Console.WriteLine("사용자:보, 컴퓨터:바위 이겼습니다.");
                            win++;
                        }
                        else
                        {
                            Console.WriteLine("제대로 다시 입력하세요.");
                        }
                        break;
                    case 3: // 보라고 생각
                        if (user.Equals("가위"))
                        {
                            Console.WriteLine("사용자:가위, 컴퓨터:보 이겼습니다.");
                            win++;
                        }
                        else if (user.Equals("바위"))
                        {
                            Console.WriteLine("사용자:바위, 컴퓨터:보 졌습니다.");
                            lose++;
                        }
                        else if (user.Equals("보"))
                        {
                            Console.WriteLine("사용자:보, 컴퓨터:보 비겼습니다.");
                            draw++;
                        }
                        else
                        {
                            Console.WriteLine("제대로 다시 입력하세요.");
                        }
                        break;
                }
            }
            Console.WriteLine("이긴횟수: " + win);
            Console.WriteLine("진횟수: " + lose);
            Console.WriteLine("비긴횟수: " + draw);
            Console.WriteLine();
        }
    }
}
