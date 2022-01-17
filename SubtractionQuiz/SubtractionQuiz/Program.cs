using System;

namespace SubtractionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Generate two random single-digit integers
            Random keygen = new Random();
            int number1 = keygen.Next(1, 10);
            int number2 = keygen.Next(1, 10);

            // 2. If number 1 < number 2, swap number1 with number2
            if (number1<number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            // 3. Prompt the student to answer, "What is number1 - number2?"
            Console.Write($"What is {number1} - {number2} = ?");
            int answer = int.Parse(Console.ReadLine());

            // 4. Check the answer
            if (answer == (number1-number2))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Wrong! The answer is {number1-number2}");
            }
        }
    }
}
