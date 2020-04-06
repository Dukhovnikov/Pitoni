using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class BullsAndCows
    {
        private int GoalNumber;
        public BullsAndCows()
        {
            Random x = new Random();
            int min = 1000;
            int max = 9999;
            do
            {
                GoalNumber = x.Next(min, max);
            } while (!MissMakukhina.ControlDifference(GoalNumber));






        }
        public void Start()
        {
            Console.WriteLine("Я хочу сыграть с тобой в игру");
            int n = 1;
            string x;
            do
            {
                Console.Write($"{n}. ");
                x = Console.ReadLine();

            }while()
        }
        private string Match(int NumberUser, int NumberComp)
        {
            
        }
    }
}
