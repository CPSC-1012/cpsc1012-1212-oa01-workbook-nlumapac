using System;

namespace MathTutor04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validMenu = false;
            char menu;

            int num1 = 0;
            int num2 = 0;
            double correctAnswer = 0;

            do
            {
                PromptMenu();
                validMenu = char.TryParse(Console.ReadLine().ToLower(), out menu);
                if (validMenu)
                {
                    GenerateTwoNumbers(out num1, out num2);

                    switch (menu)
                    {
                        case 'a':
                            correctAnswer = num1 + num2;
                            DisplayQuestion('+', num1, num2);
                            break;
                        case 's':
                            break;
                        case 'm':
                            break;
                        case 'd':
                            correctAnswer = (double)num1 / num2;
                            break;
                        case 'x':
                            Console.WriteLine("Goodbye and thanks for playing!");
                            break;
                        default:
                            validMenu = false;
                            break;
                    }
                }
                
            } while (!validMenu);


            
        }


        static void DisplayQuestion(char mathOperator, int num1, int num2)
        {
            Console.WriteLine($"What is {num1} {mathOperator} {num2}");
        }

        static void GenerateTwoNumbers(out int num1, out int num2)
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            num1 = rand.Next(1, 100);
            num2 = rand.Next(1, 100);
        }

        static void PromptMenu()
        {
            Console.WriteLine("Math Tutor - Version 0.4");
            Console.WriteLine("------------------------");
            Console.WriteLine("a) Addition");
            Console.WriteLine("b) Subtraction");
            Console.WriteLine("c) Multiplication");
            Console.WriteLine("d) Division");
            Console.WriteLine("x) Exit Program");
            Console.WriteLine("Enter a letter for your choice:");
        }
    }
}
