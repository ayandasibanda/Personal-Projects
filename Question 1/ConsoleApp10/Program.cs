using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
       // Enumeration to hold the zone names

        public enum Zone
        {
            School,
            City,
            Highway,
        }

        // 2nd Enumeration to hold the speed limits for each zone

        public enum SpeedLimit
        {
            School = 20,
            City = 30,
            Highway = 55,
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************");

            // Prompt user to enter zone
            Console.WriteLine("Please enter a zone number ");
            Console.WriteLine("1. School");
            Console.WriteLine("2. City");
            Console.WriteLine("3. Highway");
            Console.WriteLine();
            Console.WriteLine("*************************************************************");

            string zoneNumber = Console.ReadLine();

            // Validate and parse user input

            Zone Zone;
            if (!Enum.TryParse(zoneNumber, true, out Zone))
            {
                Console.WriteLine("Incorrect input. Please enter valid zone number");
                Console.ReadKey();
                return;
            }

            // Prompt user to enter driving speed
            Console.WriteLine("Please enter your current speed");
            if (!int.TryParse(Console.ReadLine(), out int driversSpeed))
            {
                Console.WriteLine("Incorrect input. Please enter valid speed");
                Console.ReadKey();
                return;

            }

            // Check if drivers speed exceeds the speed limit for the current zone
            SpeedLimit speedLimit = (SpeedLimit)Enum.Parse(typeof(SpeedLimit), Zone.ToString()); 
            if (driversSpeed > (int)speedLimit)
            {
                Console.WriteLine("Please slow down and maintain the specified speed limit in the specified zone");
                Console.ReadKey();
            }
            else if (driversSpeed < (int)speedLimit)
            {
                Console.WriteLine("Thank you for maintaining the speed limit in the specified zone");
                Console.ReadKey();
            }
           
        }
    }
}
