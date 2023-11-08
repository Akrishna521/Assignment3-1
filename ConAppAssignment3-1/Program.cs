using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Parse the input to a double
            double number;
            try
            {
                number = double.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Determine if the number is positive, negative, zero, even, or odd
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}