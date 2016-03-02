using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int NumOfPlayers;
            bool PlayerTurn = true;
            int CurrentRoll;
            char BankOrRoll;
            int TurnScore = 0;
            int CurrentPlayerNumber = 0;
            bool GameStillGoing = true;

            Console.WriteLine("Welcome to Pig Dice");
            Console.WriteLine("How many people are playing today?");
            NumOfPlayers = int.Parse(Console.ReadLine());
            //data validation

            Player[] Players = new Player[NumOfPlayers];
            for(int i =0; i < NumOfPlayers; i++)
            {
                Players[i] = new Player();
            }

            while(GameStillGoing)
            {
                Console.WriteLine();
                Console.WriteLine($"It's Player {(CurrentPlayerNumber+1)}'s turn!");
                Console.WriteLine($"Your current score is { Players[CurrentPlayerNumber].Score}");
                while (PlayerTurn)
                {
                    CurrentRoll = DiceRoll(r);
                    Console.WriteLine($"The Dice Roll was {CurrentRoll}");
                    if (CurrentRoll == 1)
                    {
                        PlayerTurn = false;
                    }
                    else
                    {
                        TurnScore = TurnScore + CurrentRoll;

                        if (Players[CurrentPlayerNumber].Score + TurnScore >= 100)
                        {
                            Console.WriteLine("Wow, you have at least 100 points! You Win!!");
                            GameStillGoing = false;
                            break;
                        }

                        Console.WriteLine($"Your score this turn is currently {TurnScore}, Which would make your score {(Players[CurrentPlayerNumber].Score + TurnScore)} if you bank now");
                        Console.Write($"Would you like to bank your {TurnScore} or roll again? ");
                        Console.WriteLine("Please enter B or R");
                        BankOrRoll = char.Parse(Console.ReadLine());
                        while (BankOrRoll != 'B' && BankOrRoll != 'b' && BankOrRoll != 'R' && BankOrRoll != 'r')
                        {
                            Console.WriteLine("Please enter B or R");
                            BankOrRoll = char.Parse(Console.ReadLine());
                        }

                        if (BankOrRoll == 'B' || BankOrRoll == 'b')
                        {
                            Players[CurrentPlayerNumber].Score += TurnScore;
                            PlayerTurn = false;
                        }

                    }
                }
                Console.WriteLine("It's not your turn anymore");
                //rotate player
                if(CurrentPlayerNumber == NumOfPlayers - 1)
                {
                    CurrentPlayerNumber = 0;
                }
                else
                {
                    CurrentPlayerNumber++;
                }
                TurnScore = 0;
                PlayerTurn = true;
            }


            Console.ReadLine();
        }

        static int DiceRoll(Random r)
        {
            int Roll = r.Next(1, 7);
            return Roll;
        }
    }

    public class Player
    {
        //string Name;
        public int Score = 0;

        /* public static void SetPlayerName(ref string name)
         {
             Console.WriteLine("What is your name?");
             name = Console.ReadLine();
         } */
    }
}
