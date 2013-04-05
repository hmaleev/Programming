using System;
using System.Collections.Generic;
using System.Text;

namespace CowsAndBullsGame
{
    public class AIPlayer : Players
    {

        public AIPlayer()
            : base()
        {
            this.PlayerName = "AI";
        }

        public int SelectNumber()
        {
            int number;
            Console.WriteLine("Please choose your number: ");
            number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
