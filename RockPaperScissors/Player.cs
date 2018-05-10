using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {



        public void ChooseRockPaperScissorsLizardOrSpock()
        {
            Console.Write("Choose Rock, Paper, Scissors, Lizard, or Spock.");
            Console.ReadLine();


        }

        public void Choices()
        {
            List<string> choices = new List<string>();
            choices.Add("Rock");
            choices.Add("Paper");
            choices.Add("Scissors");
            choices.Add("Lizard");
            choices.Add("Spock");
        }


    }
}

