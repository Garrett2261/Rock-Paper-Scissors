using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        public Player()
        {

        }

        public int SetUpPlayers()
        {
            Console.WriteLine("How many players will be playing the game? Please enter '1' or '2'.");
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                default:
                    Console.WriteLine("Please enter '1' or '2'.");
                    SetUpPlayers();
                    return 0;
            }
        }
    }
}

