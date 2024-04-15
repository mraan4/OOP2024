using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        ublic abstract class PairMap
        {
            protected string[] keyArray;
            protected string[] valueArray;

            public abstract string Get(string key);
            public abstract void Put(string key, string value);
            public abstract string Delete(string key);
            public abstract int Length();
        }

        public class Dictionary : PairMap
        {
            private int item;

            public Dictionary(int n)
            {
                keyArray = new string[n];
                valueArray = new string[n];
                item = 0;
            }

            public override string Get(string key)
            {
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (key.Equals(keyArray[i]))
                        return valueArray[i];
                }
                return null;
            }

            public override void Put(string key, string value)
            {
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (key.Equals(keyArray[i]))
                    {
                        keyArray[i] = key;
                        valueArray[i] = value;
                        return;
                    }
                }
                keyArray[item] = key;
                valueArray[item] = value;
                item++;
            }

            public override string Delete(string key)
            {
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (key.Equals(keyArray[i]))
                    {
                        string val = valueArray[i];
                        keyArray[i] = null;
                        valueArray[i] = null;
                        return val;
                    }
                }
                return null;
            }

            public override int Length()
            {
                return item;
            }
        }

        static void Main(string[] args)
        {
            Dictionary dic = new Dictionary(10);
            dic.Put("김둘리", "자바");
            dic.Put("고길동", "파이썬");
            dic.Put("고길동", "C++");
            Console.WriteLine("고길동의 값은 " + dic.Get("고길동"));
            Console.WriteLine("김둘리의 값은 " + dic.Get("김둘리"));
            dic.Delete("김둘리");
            Console.WriteLine("김둘리의 값은 " + dic.Get("김둘리"));
        }
    }
}
