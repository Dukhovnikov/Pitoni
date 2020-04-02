using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
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
