using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Triangle
    {
        int a;
        int b;
        int c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int GetPerimetr()
        {
            return a + b + c;
        }
        public double GetArea()
        {
            double p = 0.5 * GetPerimetr();
            double result;
            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }
        public void Start()
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
            Triangle z = new Triangle(a, b, c);
            Console.WriteLine($"Периметр заданного треугольника равен: {z.GetPerimetr()}");
            Console.Write($"Площадь заданного треугольника равна: {z.GetArea()}");
        }
    }
}
