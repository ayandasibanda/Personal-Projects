using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Iterate through number from 1 to 10,000
            for (int number = 1; number <= 10000; number++)
            {
                // Check if the current number is perfect
                if (NumberIsPerfect(number))
                {
                    // If the number is perfect then display it in perfect format
                    Console.WriteLine($"{number,8} is perfect");
                    Console.ReadKey();
                }
            }
        }

        // Method to check if the number is perfect
        static bool NumberIsPerfect(int number)
        {
            // Initialize a variable to store the sum of the divisors
            int sum = 0;

            // Iterate through all possible divisors of the number
            for (int i = 1; i <= number / 2; i++)
            {
                // If i is a divisor of the number, it gets added to the sum
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            // If the sum of the divisors equals to the number itself then the number is perfect
            return sum == number;
        }

    }
}
