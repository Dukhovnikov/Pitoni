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
                Console.WriteLine($"   {Match(int.Parse(x), GoalNumber)}");
                Console.WriteLine();
                n = n + 1;
            } while (int.Parse(x)!=GoalNumber);
            Console.WriteLine("Бинго!");
        }
        public string Match(int NumberUser, int NumberComp)
        {
            int[] numberuser = Array.ConvertAll(NumberUser.ToString().ToArray(), m => (int)m);
            int[] numbercomp = Array.ConvertAll(NumberComp.ToString().ToArray(), m => (int)m);
            int b = 0;
            int c = 0;
            for (int i = 0; i < numberuser.Length; i++)
            {
                for (int j = 0; j < numberuser.Length; j++)
                {
                    if (numberuser[i] == numbercomp[j])
                    {
                        c = c + 1;
                    }
                }
                if (numberuser[i] == numbercomp[i])
                {
                    b = b + 1;
                }
            }
            c = c - b;
            return $"{b}B{c}C";
        }
    }
}
