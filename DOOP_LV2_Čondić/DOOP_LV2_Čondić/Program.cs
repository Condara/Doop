using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV2_Čondić
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller roller0 = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                Dice dice = new Dice(6);
                roller0.InsertDice(dice);
            }
            roller0.RollAllDice();
            IList<int> results = roller0.GetRollingResults();
            foreach (int result in results)
            {
                Console.Write(result + ", ");
            }
            Console.WriteLine();
            Random rand = new Random();
            DiceRoller roller1 = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                Dice dice = new Dice(6, rand);
                roller1.InsertDice(dice);
            }
            roller1.RollAllDice();
            results = roller1.GetRollingResults();
            foreach (int result in results)
            {
                Console.Write(result + ", ");
            }
            Console.ReadKey();
        }
    }
}