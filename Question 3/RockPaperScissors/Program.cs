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
            string[] computerChoices = { "rock", "paper", "scissors" };

            // Generate a random choice for computer
            Random random = new Random();
            int randomChoice = random.Next(3); // Changed to generate a number between 0 and 2
            string computerChoice = computerChoices[randomChoice];

            // Prompt the user to enter their choice
            Console.WriteLine("Please enter your choice between rock, paper, scissors by entering a character!");
            Console.WriteLine("r = rock");
            Console.WriteLine("p = paper");
            Console.WriteLine("s = scissors");
            Console.WriteLine();
            string userInput = Console.ReadLine().ToLower();

            // Map user input to the corresponding choice
            string userChoice = MapUserInput(userInput);

            // Determine the winner
            string result = DetermineWinner(userChoice, computerChoice);

            // Display the result
            Console.WriteLine($"The computer chose: {computerChoice}");
            Console.WriteLine(result);

            // Terminate program
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }

        // Helper method to map user input to choice
        static string MapUserInput(string userInput)
        {
            switch (userInput)
            {
                case "r":
                    return "rock";
                case "p":
                    return "paper";
                case "s":
                    return "scissors";
                default:
                    return "invalid"; // Handle invalid input
            }
        }

        // Helper method to determine the winner
        static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "invalid")
            {
                return "Invalid choice! Please choose from rock, paper, or scissors.";
            }
            else if (userChoice == computerChoice)
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