using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //Player Player = new Player();
        int choiceIndexInList = 1;
        //Human Human = new Human();
        //AI AI = new AI();
        //Do an iteration where it goes through the list and after each choice it goes to the next choices. When it goes to the next choices, choice number 2, 
        public Game()
        {
            
        }
        public void EnterGameParamters()
        {

        }

        public void RunGame()
        {
            int count = 0;
            ShowInstructions();
            if(SetUpPlayers() == 1)
            {
                Human Human = new Human();
                AI AI = new AI();
                List<string> PlayerOneChoices = new List<string>();
                List<string> ComputerChoices = new List<string>();
                while (Human.GetScore() < 2 && AI.GetScore() < 2)
                {
                    string playerChoice = Human.MakeAChoice();
                    string computerChoice = AI.MakeAChoice();
                    PlayerOneChoices.Add(playerChoice);
                    ComputerChoices.Add(computerChoice);
                    for (int i = count; i < PlayerOneChoices.Count; i++)
                    {
                        string humanChoice;
                        string cpuChoice;
                        humanChoice = PlayerOneChoices[i];
                        for (int j = count; j < ComputerChoices.Count; j++)
                        {
                            cpuChoice = ComputerChoices[j];
                            if (humanChoice == "Rock" && (cpuChoice == "Rock" || cpuChoice == "Paper" || cpuChoice == "Scissors" || cpuChoice == "Lizard" || cpuChoice == "Spock"))
                            {
                                if (cpuChoice == "Rock")
                                {
                                    Console.WriteLine("Both of you chose Rock! No one wins.");
                                    
                                }
                                else if (cpuChoice == "Paper")
                                {
                                    Console.WriteLine("Paper covers Rock. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Scissors")
                                {
                                    Console.WriteLine("Rock crushes Scissors. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Lizard")
                                {
                                    Console.WriteLine("Rock crushes Lizard. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Spock")
                                {
                                    Console.WriteLine("Spock vaporizes Rock. The computer wins.");
                                    AI.IncreaseScore();
                                }
                            }
                            else if (humanChoice == "Paper" && (cpuChoice == "Rock" || cpuChoice == "Paper" || cpuChoice == "Scissors" || cpuChoice == "Lizard" || cpuChoice == "Spock"))
                            {
                                if (cpuChoice == "Rock")
                                {
                                    Console.WriteLine("Paper covers Rock. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Paper")
                                {
                                    Console.WriteLine("Both of you chose paper. No one wins.");
                                    
                                }
                                else if (cpuChoice == "Scissors")
                                {
                                    Console.WriteLine("Scissors cuts Paper. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Lizard")
                                {
                                    Console.WriteLine("Lizard eats Paper. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Spock")
                                {
                                    Console.WriteLine("Paper disproves Spock. You win!");
                                    Human.IncreaseScore();
                                }
                            }
                            else if (humanChoice == "Scissors" && (cpuChoice == "Rock" || cpuChoice == "Paper" || cpuChoice == "Scissors" || cpuChoice == "Lizard" || cpuChoice == "Spock"))
                            {
                                if (cpuChoice == "Rock")
                                {
                                    Console.WriteLine("Rock crushes Scissors. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Paper")
                                {
                                    Console.WriteLine("Scissors cuts Paper. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Scissors")
                                {
                                    Console.WriteLine("Both of you chose Scissors. No one wins.");
                                    
                                }
                                else if (cpuChoice == "Lizard")
                                {
                                    Console.WriteLine("Scissors decapitates Lizard. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Spock")
                                {
                                    Console.WriteLine("Spock smashes Scissors. The computer wins.");
                                    AI.IncreaseScore();
                                }
                            }
                            else if (humanChoice == "Lizard" && (cpuChoice == "Rock" || cpuChoice == "Paper" || cpuChoice == "Scissors" || cpuChoice == "Lizard" || cpuChoice == "Spock"))
                            {
                                if (cpuChoice == "Rock")
                                {
                                    Console.WriteLine("Rock crushes Lizard. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Paper")
                                {
                                    Console.WriteLine("Lizard eats Paper. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Scissors")
                                {
                                    Console.WriteLine("Scissors decapitates Lizard. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Lizard")
                                {
                                    Console.WriteLine("Both of you chose the same. No one wins.");
                                    
                                }
                                else if (cpuChoice == "Spock")
                                {
                                    Console.WriteLine("Lizard poisons Spock. You win!");
                                    Human.IncreaseScore();
                                }
                            }
                            else if (humanChoice == "Spock" && (cpuChoice == "Rock" || cpuChoice == "Paper" || cpuChoice == "Scissors" || cpuChoice == "Lizard" || cpuChoice == "Spock"))
                            {
                                if (cpuChoice == "Rock")
                                {
                                    Console.WriteLine("Spock vaporizes Rock. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Paper")
                                {
                                    Console.WriteLine("Paper disproves Spock. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Scissors")
                                {
                                    Console.WriteLine("Spock smashes Scissors. You win!");
                                    Human.IncreaseScore();
                                }
                                else if (cpuChoice == "Lizard")
                                {
                                    Console.WriteLine("Lizard poisons Spock. The computer wins.");
                                    AI.IncreaseScore();
                                }
                                else if (cpuChoice == "Spock")
                                {
                                    Console.WriteLine("Both of you chose the same. No one wins.");
                                    
                                }
                            }

                        }

                    }
                    count++;
                    //for(int i = count; i < PlayerOneChoices.Count; i++)
                    //{
                    //    string humanChoice;
                    //    string cpuChoice;
                    //    humanChoice = PlayerOneChoices[i];
                    //    for(int j = count; j < ComputerChoices.Count; j++)
                    //    {
                    //        cpuChoice = ComputerChoices[j];
                    //        if(humanChoice == "Rock" && (cpuChoice == "Scissors" || cpuChoice == "Lizard"))
                    //        {

                    //        }
                    //    }
                    //}

                }
                if(Human.GetScore() == 2 || AI.GetScore() == 2)
                {
                    if(Human.GetScore() == 2)
                    {
                        Console.WriteLine("Congratulations! You win!");
                    }
                    else if(AI.GetScore() == 2)
                    {
                        Console.WriteLine("The computer won. Better luck next time.");
                    }
                }
            }
            else if(SetUpPlayers() == 2)
            {
                Human HumanOne = new Human();
                Human HumanTwo = new Human();

            }
        }

        public void ShowInstructions()
        {
            Console.WriteLine("When playihg Rock, Paper, Scissors, Lizard, Spock, you must choose one of the options.");
            Console.WriteLine("Then Player 2 will make their choice and a winner will be decided.");
            Console.WriteLine("Rock crushes scissors, scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, and Spock vaporizes Rock.");
            Console.WriteLine("Whoever wins 2 out of 3 games will be declared the winner.");
        }

        public void CreatePlayers()
        {
            Console.WriteLine("How many players are there?");
            string numberOfPlayers = Console.ReadLine();

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
    

