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
            Console.WriteLine("Welcome to Pig Dice");
            Player Player1 = new Player();
            bool PlayerTurn = true;
            int CurrentRoll;
            char BankOrRoll;
            int TurnScore = 0;

            while (PlayerTurn)
            {
                CurrentRoll = DiceRoll();
                Console.WriteLine($"The Dice Roll was {CurrentRoll}");
                if (CurrentRoll == 1)
                {
                    PlayerTurn = false;
                }
                else
                {
                    TurnScore = TurnScore + CurrentRoll;

                    //test win
                    //if win display win text and break
                    if(Player1.Score + TurnScore >= 100)
                    {
                        Console.WriteLine("Wow, you have more than 100 points! You Win!!");
                        break;
                    }

                    Console.WriteLine($"Your Score this turn is currently {TurnScore}");
                    Console.Write($"Would you like to bank your {TurnScore} or roll again?");
                    Console.WriteLine("Please enter B or R");
                    BankOrRoll = char.Parse(Console.ReadLine());
                    while (BankOrRoll != 'B' && BankOrRoll != 'b' && BankOrRoll != 'R' && BankOrRoll != 'r')
                    {
                        Console.WriteLine("Please enter B or R");
                        BankOrRoll = char.Parse(Console.ReadLine());
                    }

                    if (BankOrRoll == 'B' || BankOrRoll == 'b')
                    {
                        Player1.Score += TurnScore;
                        PlayerTurn = false;
                    }

                }
            }



            Console.ReadLine();
        }

        static int DiceRoll()
        {
            Random r = new Random();
            int Roll = r.Next(1, 6);
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
