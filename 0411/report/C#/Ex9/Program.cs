using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        interface IStack
        {
            int Length();
            int Capacity();
            string Pop();
            bool Push(string val);
        }

        class StackApp : IStack
        {
            private int length, capacity;
            string[] arr;

            public StackApp(int n)
            {
                arr = new string[n];
                length = 0;
                capacity = n;
            }

            public int Length()
            {
                return length;
            }

            public int Capacity()
            {
                return capacity;
            }

            public string Pop()
            {
                return arr[--length];
            }

            public bool Push(string val)
            {
                if (length == capacity)
                {
                    Console.WriteLine("스택이 꽉 차서 더 이상 넣을 수 없습니다!");
                    return false;
                }
                else
                {
                    arr[length++] = val;
                    return true;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("총 스택 저장 공간의 크기 입력 >> ");
            int n = Convert.ToInt32(Console.ReadLine());

            StackApp app = new StackApp(n);

            while (true)
            {
                Console.Write("문자열 입력 >> ");
                string str = Console.ReadLine();
                if (str.Equals("stop"))
                    break;
                app.Push(str);
            }

            Console.Write("스택에 저장된 모든 문자열 출력 : ");
            foreach (string a in app.arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
