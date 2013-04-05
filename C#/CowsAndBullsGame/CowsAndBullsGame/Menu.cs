using System;
using System.Collections.Generic;
using System.Text;

namespace CowsAndBullsGame
{
     class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Single Player Game");
            Console.WriteLine("2. Multi Player Game");
        }
        public byte Selection()
        {
            return 1;
        }
    }
}
