using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RpsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가위바위보 게임입니다. 가위, 바위, 보 중에서 입력하세요");
            Console.WriteLine("철수 >> ");
            string player1 = Console.ReadLine();

            Console.WriteLine("영희 >> ");
            string player2 = Console.ReadLine();

            if (player1.Equals("바위"))
            {
                if (player2.Equals("바위"))
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if (player2.Equals("보"))
                {
                    Console.WriteLine("영희가 이겼습니다.");
                }
                else if (player2.Equals("가위"))
                {
                    Console.WriteLine("철수가 이겼습니다.");
                }
                else
                {
                    Console.WriteLine("가위 바위 보 중에 입력하세요.");
                }
            }
            else if (player1.Equals("보"))
            {
                if (player2.Equals("바위"))
                {
                    Console.WriteLine("철수가 이겼습니다.");
                }
                else if (player2.Equals("보"))
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if (player2.Equals("가위"))
                {
                    Console.WriteLine("영희가 이겼습니다.");
                }
                else
                {
                    Console.WriteLine("가위 바위 보 중에 입력하세요.");
                }
            }
            else if (player1.Equals("가위"))
            {
                if (player2.Equals("바위"))
                {
                    Console.WriteLine("영희가 이겼습니다.");
                }
                else if (player2.Equals("보"))
                {
                    Console.WriteLine("철수가 이겼습니다.");
                }
                else if (player2.Equals("가위"))
                {
                    Console.WriteLine("비겼습니다.");
                }
                else
                {
                    Console.WriteLine("가위 바위 보 중에 입력하세요.");
                }
            }
            else
            {
                Console.WriteLine("가위 바위 보 중에 입력하세요.");
            }
        }
    }

}
