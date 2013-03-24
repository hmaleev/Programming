using System;
using System.Collections.Generic;
using System.Text;

namespace CowsAndBullsGame
{
    class Program
    {
        static void Main(string[] args)
        {
             FirstPlayer playerOne = new FirstPlayer();
             SecondPlayer playerTwo = new SecondPlayer();

             bool playerOneTurn = true;
             bool playerTwoTurn = false;

             playerOne.PlayerName = "me";
             playerTwo.PlayerName = "you";

             Console.WriteLine(" Player 1 - Enter a number: ");
             playerOne.Number = Console.ReadLine();
             Console.Clear();

             Console.WriteLine(" Player 2 - Enter a number: ");
             playerTwo.Number = Console.ReadLine();
             Console.Clear();

             while (true)
             {

                 if (playerOneTurn==true)
                 {
                     Console.WriteLine("Player 1's turn");
                     Console.WriteLine("Enter a number: ");
                     playerOne.Input = Console.ReadLine();
                 }
                 else
                 {
                     Console.WriteLine("Player 2's turn");
                     Console.WriteLine("Enter a number: ");
                     playerTwo.Input = Console.ReadLine();
                 }

                 if (playerOne.Input != playerTwo.Number &&playerOneTurn==true)
                 {
                     CheckInput(playerTwo.Number, playerOne.Input);
                     playerOneTurn = false;
                     playerTwoTurn = true;
                     continue;
                 }
                 else if (playerOne.Input == playerTwo.Number &&playerOneTurn==true)
                 {
                     CheckInput(playerTwo.Number, playerOne.Input);
                     Console.WriteLine("Player 1 WINS!");
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
                     Console.WriteLine("Player 2 WINS!");
                     break;
                 }
             }
            
    
        }

        static void CheckInput(string number, string input)
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
    }
}
