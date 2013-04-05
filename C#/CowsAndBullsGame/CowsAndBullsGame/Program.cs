using System;
using System.Collections.Generic;
using System.Text;

namespace CowsAndBullsGame
{
    class Program
    {
        static void Main(string[] args)
        {
             HumanPlayer playerOne = new HumanPlayer();
             HumanPlayer playerTwo = new HumanPlayer();
             Engine engine = new Engine();
             Menu menu = new Menu();      

             menu.ShowMenu();
             Console.Clear();
             engine.Run(playerOne, playerTwo);
        }

    
    }
}
