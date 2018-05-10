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

        public void MakeAChoice()
        {
            Console.Write("Do you choose Rock, Paper, Scissors, Lizard, or Spock?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Rock":
                    Console.Write("Rock");
                    
                    break;

                case "Paper":
                    Console.Write("Paper");
                    break;

                case "Scissors":
                    Console.Write("Scissors");
                    break;

                case "Lizard":
                    Console.Write("Lizard");
                    break;

                case "Spock":
                    Console.Write("Spock");
                    break;

                default:
                    Console.Write("Please choose only 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'.");
                    MakeAChoice();
                    break;
            }
        }
    }
}
