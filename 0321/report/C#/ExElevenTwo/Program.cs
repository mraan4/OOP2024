﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExElevenTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("달을 입력하세요(1~12)>>");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                default:
                    Console.WriteLine("잘못입력");
                    break;
            }
         }
    }
}
