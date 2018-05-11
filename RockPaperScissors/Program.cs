using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            AI Computer = new AI();
            Computer.ChooseRockPaperScissorsLizardOrSpock();
            Computer.MakeAChoice();

            Human Player1 = new Human();
            Player1.ChooseRockPaperScissorsLizardOrSpock();
            Player1.MakeAChoice();
            Player1.Choices();

        }
    }
}
