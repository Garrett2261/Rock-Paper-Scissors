using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AI
    {
        int score = 0;
        public AI()
        {
            List<string> Choices = new List<string>();
        }

        public string MakeAChoice()
        {
            Console.WriteLine("The computer will now make its selection.");
            Console.ReadLine();
            Random rnd = new Random();
            int choice = rnd.Next(1, 5);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Rock");
                    Console.ReadLine();
                    return "Rock";


                case 2:
                    Console.WriteLine("Paper");
                    Console.ReadLine();
                    return "Paper";


                case 3:
                    Console.WriteLine("Scissors");
                    Console.ReadLine();
                    return "Scissors";


                case 4:
                    Console.WriteLine("Lizard");
                    Console.ReadLine();
                    return "Lizard";


                case 5:
                    Console.WriteLine("Spock");
                    Console.ReadLine();
                    return "Spock";


                default:
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
