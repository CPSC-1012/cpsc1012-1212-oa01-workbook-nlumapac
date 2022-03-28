using System;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will return the number of seconds from hours, minutes and seconds");
            int hours = PromptForPositiveNumber("Enter number of hours: ");
            int minutes = PromptForPositiveNumber("Enter number of minutes: ");
            int seconds = PromptForPositiveNumber("Enter number of seconds: ");
            int totalSeconds = CalculateSeconds(hours, minutes, seconds);
            Console.WriteLine($"The total change is {totalSeconds}");
        }

        static int CalculateSeconds(int hours, int minutes, int seconds)
        {
            int totalSeconds = 0;

            totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            return totalSeconds;
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
