using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        class Phone
        {
            private string name;
            private string tel;

            public Phone(string name, string tel)
            {
                this.name = name;
                this.tel = tel;
            }

            public string GetName()
            {
                return name;
            }

            public string GetTel()
            {
                return tel;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("인원수 >> ");
            int num = Convert.ToInt32(Console.ReadLine());
            Phone[] phone = new Phone[num];

            for (int i = 0; i < phone.Length; i++)
            {
                Console.Write("이름과 전화번호(이름과 번호는 빈 칸없이 입력)>> ");
                string name = Console.ReadLine();
                string tel = Console.ReadLine();
                phone[i] = new Phone(name, tel);
            }

            Console.WriteLine("저장되었습니다...");

            while (true)
            {
                Console.Write("검색할 이름 >> ");
                string name = Console.ReadLine();

                for (int i = 0; i < num; i++)
                {
                    if (name.Equals(phone[i].GetName()))
                    {
                        Console.WriteLine(name + "의 번호는 " + phone[i].GetTel() + " 입니다.");
                        i--;
                        break;
                    }
                }

                if (name.Equals("그만"))
                {
                    break;
                }

                if (i == num)
                {
                    Console.WriteLine(name + "이 없습니다.");
                }
            }
        }
    }
}
