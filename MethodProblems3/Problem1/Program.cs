using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will tally up the total change from user's pocket");
            int numberOfPennies = PromptForPositiveNumber("Enter number of pennies: ");
            int numberOfNickels = PromptForPositiveNumber("Enter number of nickels: ");
            int numberOfDimes = PromptForPositiveNumber("Enter number of dimes: ");
            int numberOfQuarters = PromptForPositiveNumber("Enter number of quarters: ");
            int numberOfLoonies = PromptForPositiveNumber("Enter number of loonies: ");
            int numberOfTwoonies = PromptForPositiveNumber("Enter number of twoonies: ");
            double total = GetTotal(numberOfPennies, numberOfNickels, numberOfDimes, numberOfQuarters, numberOfLoonies, numberOfTwoonies);
            Console.WriteLine($"The total change is {total}");
        }

        static double GetTotal(int numberOfPennies, int numberOfNickels, int numberOfDimes,
            int numberOfQuarters, int numberOfLoonies, int numberOfTwoonies)
        {
            double total = 0.00;

            total = (numberOfPennies * 0.01) + (numberOfNickels * 0.05) + (numberOfDimes * 0.10) +
                (numberOfQuarters * 0.25) + numberOfLoonies + (numberOfTwoonies * 2);

            return Math.Round(total, 2);
        }

        static int PromptForPositiveNumber(string prompt)
        {
            int value = 0;
            bool success = false;

            while (!success)
            {
                Console.Write(prompt);
                success = int.TryParse(Console.ReadLine(), out value);

                if (!success || value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input must be integer and positive number. Try again.");
                    Console.ResetColor();
                    success = false;
                }
            }

            return value;
        }
    }
}
