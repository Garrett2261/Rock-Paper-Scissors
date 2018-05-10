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
            Console.Write(choice);
            Console.ReadLine();
        }
    }
}
