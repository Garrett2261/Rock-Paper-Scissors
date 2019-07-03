using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human
    {
        int score = 0;
        public Human()
        {
            List<string> Choices = new List<string>();
        }

        public string MakeAChoice()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock?");
            string choice = Console.ReadLine().ToLower();
            
            switch (choice)
            {
                case "rock":
                    Console.WriteLine("Rock");
                    return "Rock";
                case "paper":
                    Console.WriteLine("Paper");
                    return "Paper";

                case "scissors":
                    Console.WriteLine("Scissors");
                    return "Scissors";

                case "lizard":
                    Console.WriteLine("Lizard");
                    return "Lizard";

                case "spock":
                    Console.WriteLine("Spock");
                    return "Spock";

                default:
                    Console.WriteLine("Please choose only Rock, Paper, Scissors, Lizard, or Spock.");
                    MakeAChoice();
                    return null;
            }
        }

        public int GetScore()
        {
            return score;
        }
        public void IncreaseScore()
        {
            score++;
        }
    }
}
