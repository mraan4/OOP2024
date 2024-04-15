using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        abstract class Shape
        {
            private Shape _next;

            public Shape()
            {
                _next = null;
            }

            public void SetNext(Shape obj)
            {
                _next = obj;
            }

            public Shape GetNext()
            {
                return _next;
            }

            public abstract void Draw();
        }

        class Line : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Line");
            }
        }

        class Rect : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rect");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle");
            }
        }

        class GraphicEditor
        {
            private string _name;
            private Shape _head = null;
            private Shape _tail = null;

            public GraphicEditor(string name)
            {
                _name = name;
            }

            public void Run()
            {
                Console.WriteLine("그래픽 에디터 " + _name + "을(를) 실행합니다.");
                while (true)
                {
                    Console.WriteLine("1.삽입 2.삭제 3.모두 보기 4.종료 >> ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("1. Line 2. Rect 3. Circle >> ");
                            int spNum = Convert.ToInt32(Console.ReadLine());
                            Insert(spNum);
                            break;
                        case 2:
                            Console.WriteLine("삭제할 도형의 위치 >> ");
                            int delNum = Convert.ToInt32(Console.ReadLine());
                            Delete(delNum);
                            break;
                        case 3:
                            Print();
                            break;
                        case 4:
                            Console.WriteLine(_name + " 을(를) 종료합니다.");
                            return;
                        default:
                            Console.WriteLine("잘못 입력하셨습니다.");
                            break;
                    }
                }
            }

            public void Insert(int spNum)
            {
                Shape shape;
                switch (spNum)
                {
                    case 1:
                        shape = new Line();
                        break;
                    case 2:
                        shape = new Rect();
                        break;
                    case 3:
                        shape = new Circle();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        return;
                }
                if (_head == null)
                {
                    _head = shape;
                    _tail = _head;
                }
                else
                {
                    _tail.SetNext(shape);
                    _tail = shape;
                }
            }

            public void Delete(int delNum)
            {
                Shape current = _head;
                Shape a = _head;
                int i;
                if (delNum == 1)
                {
                    if (_head == _tail)
                    {
                        _head = null;
                        _tail = null;
                        return;
                    }
                    else
                    {
                        _head = _head.GetNext();
                        return;
                    }
                }
                for (i = 1; i < delNum; i++)
                {
                    a = current;
                    current = current.GetNext();
                    if (current == null)
                    {
                        Console.WriteLine("삭제할 수 없습니다.");
                        return;
                    }
                }
                if (i == delNum)
                {
                    a.SetNext(current.GetNext());
                    _tail = a;
                }
                else
                {
                    a.SetNext(current.GetNext());
                }
            }

            public void Print()
            {
                Shape shape = _head;
                while (shape != null)
                {
                    shape.Draw();
                    shape = shape.GetNext();
                }
            }
        }
        static void Main(string[] args)
        {
            GraphicEditor ge = new GraphicEditor("happy");
            ge.Run();
        }
    }
}
