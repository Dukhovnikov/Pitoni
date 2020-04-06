using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class LuckyServise
    {
        public void Run()
        {
            Console.WriteLine("Введите шестизначное число");
            int number = int.Parse(Console.ReadLine());
            string snumber = number.ToString();
            int a = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                a = a + int.Parse(snumber[i].ToString());
                b = b + int.Parse(snumber[snumber.Length - 1 - i].ToString());

            }
            if(a==b)
            {
                Console.WriteLine("Ура! Ваши числа счастливые");
            }
            else
            {
                Console.WriteLine("Вы неудачник");

            }

        }
    }
}
