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
            double p = 0.5*GetPerimetr();
            double result;
            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
            }
    }
}
