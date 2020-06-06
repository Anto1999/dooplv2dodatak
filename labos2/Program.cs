using System;

namespace labos2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            foreach(int i in diceRoller.GetRollingResults())
            {
                Console.WriteLine(i);
            }

        }
    }
}
