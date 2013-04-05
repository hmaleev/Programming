using System;
using System.Collections.Generic;
using System.Text;

namespace CowsAndBullsGame
{
     class Engine
    {
     public  void CheckInput(string number, string input)
        {
            Console.Clear();
            char[] numberArray = new char[4];
            char[] inputArray = new char[4];
            int cowCount = 0;
            int bullCount = 0;
            numberArray = number.ToCharArray();
            inputArray = input.ToCharArray();

            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (numberArray[i] == inputArray[j] && i == j)
                    {
                        bullCount++;
                        break;
                    }
                    if (numberArray[i] == inputArray[j] && i != j)
                    {
                        cowCount++;
                        break;
                    }
                }
            }

            Console.WriteLine("Cows - {0}", cowCount);
            Console.WriteLine("Bulls - {0}", bullCount);
        }

     public void Run(HumanPlayer playerOne,HumanPlayer playerTwo)
     {
         bool playerOneTurn = true;
         bool playerTwoTurn = false;

         while (true)
         {
               if (playerOneTurn == true)
         {
             Console.WriteLine("{0}'s turn", playerOne.PlayerName);
             Console.WriteLine("Enter a number: ");
             playerOne.Input = Console.ReadLine();
         }
         else
         {
             Console.WriteLine("{0}'s turn", playerTwo.PlayerName);
             Console.WriteLine("Enter a number: ");
             playerTwo.Input = Console.ReadLine();
         }

         if (playerOne.Input != playerTwo.Number && playerOneTurn == true)
         {


             CheckInput(playerTwo.Number, playerOne.Input);
             playerOneTurn = false;
             playerTwoTurn = true;
             continue;
         }
         else if (playerOne.Input == playerTwo.Number && playerOneTurn == true)
         {
             CheckInput(playerTwo.Number, playerOne.Input);
             Console.WriteLine("{0} WINS!", playerOne.PlayerName);
             break;
         }

         if (playerTwo.Input != playerOne.Number && playerTwoTurn == true)
         {
             CheckInput(playerOne.Number, playerTwo.Input);
             playerOneTurn = true;
             playerTwoTurn = false;
         }
         else if (playerTwo.Input == playerOne.Number && playerTwoTurn == true)
         {
             CheckInput(playerOne.Number, playerTwo.Input);
             Console.WriteLine("{0} WINS!", playerTwo.PlayerName);
             break;
         }
         }
     }
    }

}
