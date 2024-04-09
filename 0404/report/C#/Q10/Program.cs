using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        class Dictionary
        {
            private static string[] kor = { "사랑", "아기", "돈", "미래", "희망" };
            private static string[] eng = { "love", "baby", "money", "future", "hope" };

            public static string KorToEng(string word)
            {
                for (int i = 0; i < kor.Length; i++)
                {
                    if (word.Equals(kor[i]))
                    {
                        if (i % 2 == 0)
                            Console.Write(word + "은 ");
                        else
                            Console.Write(word + "는 ");
                        return eng[i];
                    }
                }
                return "false";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("한영 단어 검색 프로그램입니다.");
            while (true)
            {
                Console.Write("한글 단어?");
                string search = Console.ReadLine();
                if (search.Equals("그만")) break;
                string eng = Dictionary.KorToEng(search);
                if (eng.Equals("false"))
                    Console.WriteLine(search + "는 저의 사전에 없습니다.");
                else
                    Console.WriteLine(eng);
            }
        }
    }
}
