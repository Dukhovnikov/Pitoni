using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 8, 7, 2, 0, 1, 2,25,-3,56,-13,8,7 };
            string a = "Неотсортированный массив";
            Console.WriteLine(a);
            Console.WriteLine();
            for(int i = 0; i < x.Length; i++) 
            {
                Console.Write($" {x[i]} \t"); 
            }
            Console.WriteLine(); 
            Console.WriteLine();
            string b = "Отсортированный массив";
            Console.WriteLine(b);
            int z = 0;
            int v = 0;
            for(int i=0;i<x.Length;i++) 
            {
                for(int j=1;j<x.Length-z;j++)
                {
                    if (x[j-1]>x[j])
                    {
                        v = x[j-1];
                        x[j-1] = x[j];
                        x[j] = v;
                    }
                }
                z++;
            }
            for(int i=0;i<x.Length;i++)
            {
                Console.Write($"{x[i]} \t");
            }
            Console.ReadKey();
        }
    }
}
