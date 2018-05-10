using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
        public Human()
        {

        }

        public void PickRockPaperScissorsLizardSpock()
        {
            Console.Write("Do you choose Rock, Paper, Scissors, Lizard, or Spock?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Rock":

                case "Paper":

                case "Scissors":

                case "Lizard":

                case "Spock":

                default:
                    Console.Write("Please choose only 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'.");
                    PickRockPaperScissorsLizardSpock();
                    break;
            }
        }
    }
}
