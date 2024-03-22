using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of choices for the computer to choose from
            string[] computerChoices = { "rock", "paper", "scissors"};

            // Generate a random choice for computer
            Random random = new Random();
            int randomChoice = random.Next(0, 2); // Generates a random index between 0 and 2
            string computerChoice = computerChoices[randomChoice];

            // Prompt the user to enter their choice
            Console.WriteLine("Please enter your choice between rock, paper, scissors by entering a character!");
            Console.WriteLine("r = rock");
            Console.WriteLine("p = paper");
            Console.WriteLine("s = scissors");
            Console.WriteLine();
            string userChoice = Console.ReadLine().ToLower();

            // Determine the winner
            string result = DetermineWinner(userChoice, computerChoice);

            // Display the result
            Console.WriteLine($"The computer chose: {computerChoice}");
            Console.WriteLine(result);

            // Terminate program
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }

        // Helper method to determine the winnder
        static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "It is a tie!";
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "paper" && computerChoice == "rock") ||
                (userChoice == "scissors" && computerChoice == "paper"))
            {
                return "You are the winner! Congratulations, you outsmarted a machine!";
            }
            else
            {
                return "The computer wins! Looks like the computer has a PhD in Rock-Paper-Scissorology!";
            }

        }

    }
}
