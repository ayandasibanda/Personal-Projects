using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
        // Enumeration to represent different zones
        enum Zone
        {
            School = 1,  // 1 represents School zone
            City,       // 2 represents City zone
            Highway     // 3 represents Highway zone

        }

        // Enumeration to represent speed limits for each zone
        enum SpeedLimit
        {
            SchoolZoneSpeed = 20,  // Speed limit for School zone is 20
            CityStreetSpeed = 30,  // Speed limit for City zone is 30
            HighwaySpeed = 55      // Speed limit for Highway zone is 55
        }

        static void Main(string[] args)
        {
            Zone zone;          // Variable to store selected zone
            SpeedLimit speedLimit;  // Variable to store speed limit of selected zone
            int zoneNumber;     // Variable to store zone number input by the user

            // Display options for selecting a zone
            Console.WriteLine("*****************************");
            Console.WriteLine("Please enter a zone number");
            Console.WriteLine("1. School");
            Console.WriteLine("2. City");
            Console.WriteLine("3. Highway");
            Console.WriteLine("*****************************");

            // Read the zone number input by the user
            zoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Prompt the user to enter current speed
            Console.WriteLine("Please enter your current speed:");
            int currentSpeed = Convert.ToInt32(Console.ReadLine());

            // Convert the zone number to Zone enumeration
            zone = (Zone)zoneNumber;

            // Determine speed limit based on the selected zone
            switch (zone)
            {
                case Zone.School:
                    speedLimit = SpeedLimit.SchoolZoneSpeed;
                    if (currentSpeed > (int)speedLimit)
                    {
                        Console.WriteLine("Slow down and maintain the speed limit of 20 in the School zone");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for maintaining the speed limit in the School zone");
                    }
                    break;
                case Zone.City:
                    speedLimit = SpeedLimit.CityStreetSpeed;
                    if (currentSpeed > (int)speedLimit)
                    {
                        Console.WriteLine("Slow down and maintain the speed limit of 30 in the City zone");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for maintaining the speed limit in the City zone");
                    }
                    break;
                case Zone.Highway:
                    speedLimit = SpeedLimit.HighwaySpeed;
                    if (currentSpeed > (int)speedLimit)
                    {
                        Console.WriteLine("Slow down and maintain the speed limit of 55 on the Highway");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for maintaining the speed limit on the Highway");
                    }
                    break;
            }

            // Keep the console window open until a key is pressed
            Console.Read();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}