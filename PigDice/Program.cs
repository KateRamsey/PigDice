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
            Console.ReadLine();
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
