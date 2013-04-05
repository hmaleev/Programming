using System;
using System.Collections.Generic;
using System.Text;

namespace CowsAndBullsGame
{
    public class HumanPlayer : Players
    {

        public HumanPlayer():base()
        {
            this.PlayerName = ChooseName();
            this.Number = SelectNumber();
        }
        public string SelectNumber()
        {
            string number;
            Console.WriteLine();
            Console.WriteLine("{0} - Please choose your number: ",this.PlayerName);
            number = Console.ReadLine();
            return number;
        }
        public string ChooseName()
        {
            string name;
            Console.WriteLine("Please choose your name: ");
            name = Console.ReadLine();
            return name;
        }

    }
}
