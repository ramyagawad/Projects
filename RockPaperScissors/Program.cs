using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Console;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            map.Add("win", 0);

            map.Add("lose", 0);

            map.Add("tie", 0);

            int noOfRounds;

            char choice;

            do
            {

                C.WriteLine("Enter the number of rounds between 1 and 10: ");

                noOfRounds = int.Parse(C.ReadLine());

                if ((noOfRounds < 1) || (noOfRounds > 10))
                {
                    C.WriteLine("Input should be between 1 and 10");

                    C.Read();

                    Environment.Exit(0);
                }

                for (int itr = 0; itr < noOfRounds; itr++)
                {
                    C.WriteLine("Please enter the below requested choice:\nRock(1)\nPaper(2)\nScissors(3)\nEnter 1/2/3: ");

                    int userChoice = Convert.ToInt32(C.ReadLine());

                    int randomPick = new Random().Next(1, 4);

                    switch (userChoice)
                    {
                        case 1:
                            C.WriteLine("You picked Rock");
                            break;
                        case 2:
                            C.WriteLine("You picked Paper");
                            break;
                        case 3:
                            C.WriteLine("You picked Scissors");
                            break;
                    }

                    switch (randomPick)
                    {
                        case 1:
                            C.WriteLine("Computer picked Rock");
                            break;
                        case 2:
                            C.WriteLine("Computer picked Paper");
                            break;
                        case 3:
                            C.WriteLine("Computer picked Scissors");
                            break;
                    }

                    if (userChoice == randomPick)
                        map["tie"] = map["tie"] + 1;

                    else
                    {
                        if (userChoice == 1)
                        {
                            if (randomPick == 2)
                                map["lose"] = map["lose"] + 1;

                            if (randomPick == 3)
                                map["win"] = map["win"] + 1;
                        }

                        if (userChoice == 2)
                        {
                            if (randomPick == 1)
                                map["win"] = map["win"] + 1;

                            if (randomPick == 3)
                                map["lose"] = map["lose"] + 1;
                        }

                        if (userChoice == 3)
                        {
                            if (randomPick == 1)
                                map["lose"] = map["lose"] + 1;

                            if (randomPick == 2)
                                map["win"] = map["win"] + 1;
                        }
                    }
                }

                C.WriteLine("No of Wins: {0}", map["win"]);

                C.WriteLine("No of Ties: {0}", map["tie"]);

                C.WriteLine("No of Loses: {0}", map["lose"]);

                if ((map["tie"] == noOfRounds) || (map["win"] == map["lose"]))
                    C.WriteLine("Game Draw");

                else
                {
                    if (map["win"] > map["lose"])
                        C.WriteLine("You Won");
                    else
                        C.WriteLine("Computer Won");
                }

                C.WriteLine("Do you want to play again?(Y/N)");

                choice = char.Parse(C.ReadLine());

            } while ((choice == 'Y') || (choice == 'y'));

            C.WriteLine("Thanks for Playing");

            C.Read();
        }
    }
}
