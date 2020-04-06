using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            BullsAndCows Game = new BullsAndCows();

            Game.Start();
            Console.ReadKey();

        }


        private static void Try1()
        {
            Console.WriteLine("ВВедите число");
            string y = Console.ReadLine();
            int x;
            x = int.Parse(y);
            Console.WriteLine(MissMakukhina.FibonacciRec(x));
        }
        private static void Try2()
        {
            Console.WriteLine("Введите четырехзначное число");
            int x = int.Parse(Console.ReadLine());
            bool c = MissMakukhina.ControlDifference(x);
            if (c)
            {
                Console.WriteLine("Ваше число подходит нашей игре");
            }
            else
            {
                Console.WriteLine("Ваше число не подходит нашей игре");
            }
        }

    }
}
