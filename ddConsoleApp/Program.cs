using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point data = new Point(5,7);

            Console.WriteLine(data);


            Console.ReadKey();
        }

        public class Point
        {
            public int x;
            public int y;
           public string

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }


            public override string ToString()
            {
                return $"[{x} ; {y}]";
            }
        }
    }
}
