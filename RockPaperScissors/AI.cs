using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class AI : Player
    {
        public AI()
        {

        }

        public void PickEitherRockPaperScissorsLizardOrSpock()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 5);

            switch (choice)
            {
                case 1:
                    Console.Write("Rock");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("Paper");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Scissors");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Write("Lizard");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.Write("Spock");
                    Console.ReadLine();
                    break;

                default:
                    break;
                
                
            }
            
        }
    }
}
