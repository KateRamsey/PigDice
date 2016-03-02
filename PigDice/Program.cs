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
            Player Player1 = new Player();
            Player1.Score = 5;
            Console.WriteLine($"Player Score is {Player1.Score}");

                //roll dice
                //if roll == 1 bust
                //else add roll to turnscore

                //choose roll or bank
                //if bank
                // add turnscore to score and break out of turn

            //test win
            //if win display win text



            Console.ReadLine();
        }

        static int DiceRoll()
        {
            Random r = new Random();
            int Roll = r.Next(1,6);
            return Roll;
        }
    }

    public class Player
    {
        //string Name;
        public int Score;
        public int TurnScore;

       /* public static void SetPlayerName(ref string name)
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        } */
    }
}
