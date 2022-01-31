using System;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Generate a random number to be guessed
            Random keygen = new Random();
            int number = keygen.Next(1, 101);

            // Prompt the user to guess the number
            Console.Write("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());

            // Compare the number and the guess
            while (number != guess)
            {
                if (guess > number)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }

                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
            }

            // Display the result
            Console.WriteLine("Yes, the number is " + number);
        }
    }
}
