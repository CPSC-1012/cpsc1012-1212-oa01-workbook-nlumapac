using System;

namespace MathTutor02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Attempts tracker
            int attempts = 1;

            bool tryAgain = false;

            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            // Compute the correct additional answer
            int correctAnswer = num1 + num2;

            do
            {
                // Prompt the user for the answer to the addition question
                int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ? ");

                // Determine if the user answer is correct
                if (userAnswer == correctAnswer)
                {
                    // Correct Answer
                    Console.WriteLine($"Correct! You got the correct answer in {attempts} attempts");
                    tryAgain = false;
                }
                else
                {
                    //tryAgain = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false; //another way to do
                    tryAgain = IncorrectAnswerPrompt();
                    attempts++;
                }
            } while (tryAgain);  
        }

        static bool IncorrectAnswerPrompt()
        {
            char tryAgain = 'n';
            bool validTryAgain = false;

            while (!validTryAgain)
            {
                Console.Write($"Incorrect! Would you like to try again (y/n)? ");
                validTryAgain = char.TryParse(Console.ReadLine().ToLower(), out tryAgain);

                if (tryAgain == 'y' || tryAgain == 'n')
                {
                    validTryAgain = true;
                }
                else
                {
                    validTryAgain = false;
                }
            }

            if (tryAgain == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int PromptForIntegerValue(string message)
        {
            int integerValue = 0;
            string userInput = "";
            bool validUserInput = false;

            // Prompt the user using the message parameter variable
            Console.Write(message);

            while (validUserInput == false)
            {

                userInput = Console.ReadLine();
                if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("I don't know. Why don't you tell me the answer.");
                }

                validUserInput = int.TryParse(userInput, out integerValue );

                if (!validUserInput)
                {
                    // Input value is not an integer
                    Console.WriteLine("Invalid input! You must enter an integer value for the answer.");
                    Console.Write(message);
                }  
            }

            return integerValue;
        }
    }
}