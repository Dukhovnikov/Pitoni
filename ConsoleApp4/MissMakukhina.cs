using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class MissMakukhina
    {
        static public int[] toArray(string x)
        {
            string[] y = x.Split(' ');
            int[] z = new int[y.Length];
            for (int i = 0; i < y.Length; i++)
            {
                z[i] = int.Parse(y[i]);
            }
            return z;
        }
        static public void PrintArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]} \t");
            }
        }
        static public int FindMax(int[] x)
        {
            int max = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (max < x[i])
                {
                    max = x[i];
                }
            }
            return max;
        }
        static public int Factorial(int x)
        {
            int y = 1;
            while (x > 1)
            {
                y = y * x;
                x = x - 1;
            }
            return y;
        }
        static public int[] Fibonacci(int x)
        {
            int[] fib = new int[x];
            fib[0] = 1;
            fib[1] = 1;
            for (int i = 2; i < x; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib;
        }
        static public int FactorialRec(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * FactorialRec(x - 1);
            }
        }
        static public int FibonacciRec(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRec(x - 1) + FibonacciRec(x - 2);
            }
        }
        static public bool ControlDifference(int x)
        {
            int[] z = Array.ConvertAll(x.ToString().ToArray(), w => (int)w);
            for (int i = 0; i < z.Length - 1; i++)
            {
                for (int j = i + 1; j < z.Length; j++)
                {
                    if (z[i] == z[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
