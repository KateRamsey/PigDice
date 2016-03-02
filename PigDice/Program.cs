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

            Console.ReadLine();
        }
    }

    class Player
    {
        string Name;
        int Score;
        int TurnScore;

        static void SetPlayerName(ref string name)
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
    }
}
