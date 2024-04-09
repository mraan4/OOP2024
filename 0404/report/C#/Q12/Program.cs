using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        class Concert
        {
            private string[] S;
            private string[] A;
            private string[] B;

            public Concert()
            {
                S = new string[10];
                A = new string[10];
                B = new string[10];
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = "___";
                    A[i] = "___";
                    B[i] = "___";
                }
            }

            public static void PrintSeat(string[] seat)
            {
                for (int i = 0; i < seat.Length; i++)
                {
                    Console.Write(" " + seat[i] + " ");
                }
                Console.WriteLine();
            }

            public void AllPrint()
            {
                Console.Write("S>>");
                Concert.PrintSeat(S);
                Console.Write("A>>");
                Concert.PrintSeat(A);
                Console.Write("B>>");
                Concert.PrintSeat(B);
                Console.WriteLine("<<<조회를 완료하였습니다.>>>");
            }

            public void ChoiceSeat()
            {
                while (true)
                {
                    Console.Write("좌석구분 S(1), A(2), B(3>>");
                    int select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.Write("S>>");
                            PrintSeat(S);
                            InputSeat(S);
                            return;
                        case 2:
                            Console.Write("A>>");
                            PrintSeat(A);
                            InputSeat(A);
                            return;
                        case 3:
                            Console.Write("B>>");
                            PrintSeat(B);
                            InputSeat(B);
                            return;
                        default:
                            Console.WriteLine("다시 입력해 주세요.");
                            break;
                    }
                }
            }

            public void InputSeat(string[] seat)
            {
                Console.Write("이름>>");
                string name = Convert.ToString(seat[0]);
                while (true)
                {
                    Console.Write("번호>>");
                    int num = Convert.ToInt32(Console.ReadLine());
                    num--;
                    if (seat[num].Equals("___"))
                    {
                        seat[num] = name;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("다른 좌석을 선택해 주세요.");
                    }
                }
            }

            public void DChoiceSeat()
            {
                while (true)
                {
                    Console.Write("좌석 S:1, A:2, B:3>>");
                    int select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.Write("S>>");
                            PrintSeat(S);
                            Delete(S);
                            return;
                        case 2:
                            Console.Write("A>>");
                            PrintSeat(A);
                            Delete(A);
                            return;
                        case 3:
                            Console.Write("B>>");
                            PrintSeat(B);
                            Delete(B);
                            return;
                        default:
                            Console.WriteLine("다시 입력해 주세요.");
                            break;
                    }
                }
            }

            public void Delete(string[] seat)
            {
                Console.Write("이름>>");
                string name = Convert.ToString(seat[0]);
                for (int i = 0; i < seat.Length; i++)
                {
                    if (name.Equals(seat[i]))
                    {
                        seat[i] = "___";
                        break;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("명품콘서트홀 예약 시스템입니다.");
            Concert concert = new Concert();
            while (true)
            {
                Console.Write("예약:1, 조회:2, 취소:3, 끝내기:4 >> ");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        concert.ChoiceSeat();
                        break;
                    case 2:
                        concert.AllPrint();
                        break;
                    case 3:
                        concert.DChoiceSeat();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("다시 입력해 주세요.");
                        break;
                }
            }
        }
    }
}
