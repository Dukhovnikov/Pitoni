using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public class Point
        {
            int x;
            int y;

            Point next;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public class List
        {
            Point head;
            public void Add(Point point)
            {
                head = point;
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10);
            Point p2 = new Point(2, 4);

            List list = new List();

            list.Add(p1);
            list.Add(p2);
        }




        //private static void Try1()
        //{
        //BullsAndCows Game = new BullsAndCows();
        //Game.Start();
        //    Console.WriteLine("ВВедите число");
        //    string y = Console.ReadLine();
        //    int x;
        //    x = int.Parse(y);
        //    Console.WriteLine(MissMakukhina.FibonacciRec(x));
        //}
        //private static void Try2()
        //{
        //    Console.WriteLine("Введите четырехзначное число");
        //    int x = int.Parse(Console.ReadLine());
        //    bool c = MissMakukhina.ControlDifference(x);
        //    if (c)
        //    {
        //        Console.WriteLine("Ваше число подходит нашей игре");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ваше число не подходит нашей игре");
        //    }
        //}

    }
}
