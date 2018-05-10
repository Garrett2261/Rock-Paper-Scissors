using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player { 
        public string decision;
        
    
        public void ChooseRockPaperScissorsLizardOrSpock()
        {
            Console.Write("Choose Rock, Paper, Scissors, Lizard, or Spock.");
            string choice = Console.ReadLine();

        switch (choice)
        {
            case "Rock":

            case "Paper":

            case "Scissors":

            case "Lizard":

            case "Spock":

            default:
                    Console.Write("Please select only 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'");
                    break;
        }
        }
    }
}
