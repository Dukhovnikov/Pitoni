using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddConsoleApp
{
    public class BullsAndCowsService
    {
        public void Run()
        {
            Random random = new Random();

            int numberToFind = random.Next(1000, 9999);

            Console.WriteLine("I conceived a four-digit number. You must find it.");

            int userInput = 0;
            int stepCount = 1;
            while (userInput != numberToFind)
            {
                Console.Write($"{stepCount}. ");
                userInput = int.Parse(Console.ReadLine());

            }
        }


    }
}
