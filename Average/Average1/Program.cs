using System;

namespace Average1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SentinelValue = 999;

            int sum = 0;
            int counter = 0;
            int number = 0;

            while (number != SentinelValue)
            {
                number = PromptForPositiveNumber("Enter a series of numbers (999 to quit): ");
                
                if (number != SentinelValue)
                {
                    sum = sum + number;
                    counter++;
                }
            }

            Console.WriteLine($"The average of the {counter} is {sum/counter}");
        }

        static int PromptForPositiveNumber(string input)
        {
            int value = 0;
            bool success = false;

            while (!success)
            {
                Console.Write(input);
                success = int.TryParse(Console.ReadLine(), out value);

                if (!success && value <= 0)
                {
                    success = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Input must be a valid positive number. Try again.");
                    Console.ResetColor();
                }
            }

            return value;
        }
    }
}
