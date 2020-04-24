using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Node
    {
        int data;
        Node next;
    }

    public static class Write
    {
        private static Action<int, int, char> printSymbol = (xp, yp, symbol) => { Console.SetCursorPosition(xp, yp); Console.Write(symbol); };
        public static void Circle(int centerX, int centerY, int radius = 4)
        {
            try
            {
                int x = -radius;
                int y;

                printSymbol(centerX, centerY, '0');

                while (x <= radius)
                {
                    y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));
                    printSymbol(x + centerX, y + centerY, '*');

                    y = -y;
                    printSymbol(x + centerX, y + centerY, '*');

                    x++;
                }
            }
            catch (Exception)
            {
            }


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Write.Circle(1, 1);


            Console.ReadLine();
        }

        static void Main1(string[] args)
        {
            int x;
            int y;
            int r;

            r = 0;

            Console.WriteLine("Введите количество строк массива");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine();
            string a = "Cгенерирован двумерный массив";
            Console.WriteLine(a);

            int[,] z = new int[x, y];
            int k = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    z[i, j] = x * y - k;
                    k++;
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{z[i, j]} \t");

                    if (z[i, j] % 2 == 0)
                    {
                        r++;
                    }

                }

                Console.WriteLine();
                Console.WriteLine();

            }

            string b = "Количество четных элементов:";

            Console.Write(b + " ");
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }


}
