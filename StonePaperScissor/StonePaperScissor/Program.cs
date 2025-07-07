using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#...........     Welcome TO!   .........#");
            Console.WriteLine("\n#...........Stone Paper Scissor Game.........#");
            Console.WriteLine("\n#...........A Mini Project For FUN! .........#");

            string[] options = { "stone", "paper", "scissor" };
            Random rand = new Random();

            while (true)
            {
                Console.Write("\nEnter your choice (Stone / Paper / Scissor / exit to quit): ");
                string userchoice = Console.ReadLine().ToLower();

                if (userchoice == "exit")
                {
                    Console.WriteLine("\nThanks for playing the Game.\nGood Bye!");
                    break;
                }

                if (userchoice != "stone" && userchoice != "paper" && userchoice != "scissor")
                {
                    Console.WriteLine("\nInvalid Choice! Please enter stone, paper, or scissor.");
                    continue;
                }

                int computerIndex = rand.Next(0, 3);
                string computerchoice = options[computerIndex];

                Console.WriteLine($"Computer Chose: {computerchoice}");

                if (userchoice == computerchoice)
                {
                    Console.WriteLine("\nIt's a Draw!");
                }
                else if ((userchoice == "stone" && computerchoice == "scissor") ||
                         (userchoice == "paper" && computerchoice == "stone") ||
                         (userchoice == "scissor" && computerchoice == "paper"))
                {
                    Console.WriteLine("\nYou Win!");
                }
                else
                {
                    Console.WriteLine("\nComputer Wins!");
                }
            }
        }
    }
}
