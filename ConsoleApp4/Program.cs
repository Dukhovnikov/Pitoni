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
            int a;
            int b;
            int c;
            Console.WriteLine("Введите первую сторону");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону");
            c = int.Parse(Console.ReadLine());
            Triangle z = new Triangle(a,b,c);
            Console.WriteLine($"Периметр заданного треугольника равен: {z.GetPerimetr()}");
            Console.Write($"Площадь заданного треугольника равна: {z.GetArea()}");
            Console.ReadKey();
        }
    }
}
