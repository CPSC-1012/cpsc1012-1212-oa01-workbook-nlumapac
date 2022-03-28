using System;
namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SentinelFlag = 666;

            int menuChoice;

            bool validMenuChoice = false;
            bool validInput = false;

            int playerNumber = 0;
            int playerPoints = 0;
            
            do
            {
                Console.WriteLine("Hockey Player Stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Enter player number (between 1 and 99)");
                Console.WriteLine("2. Enter player points (0 or more)");
                Console.WriteLine("99. Display player info (number of points)");
                Console.WriteLine("666. Exit program.");
                Console.Write("Enter your choice>: ");
                validMenuChoice = int.TryParse(Console.ReadLine(), out menuChoice);

                //Check the menu choices
                if (validMenuChoice && (menuChoice == 1 || menuChoice == 2 || menuChoice == 99 || menuChoice == SentinelFlag))
                {
                    validMenuChoice = true;
                }

                if (validMenuChoice)
                {
                    switch (menuChoice)
                    {
                        case 1:
                            do
                            {
                                Console.Write("1. Enter player number (between 1 and 99): ");
                                validInput = int.TryParse(Console.ReadLine(), out playerNumber);
                                if (validInput)
                                {
                                    if (playerNumber < 1 || playerNumber > 99)
                                    {
                                        Console.WriteLine($"The hockey player number must be between 1 and 99.");
                                        validInput = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input value. Try again.");
                                }
                            } while (!validInput);
                            break;
                        case 2:
                            do
                            {
                                Console.Write("2. Enter player points (0 or more): ");
                                validInput = int.TryParse(Console.ReadLine(), out playerPoints);
                                if (validInput)
                                {
                                    if (playerPoints < 0)
                                    {
                                        Console.WriteLine($"The hockey player points must be 0 or more.");
                                        validInput = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input value. Try again.");
                                }
                            } while (!validInput);
                            break;
                        case 99:
                            Console.WriteLine($"The hockey player number is {playerNumber} with {playerPoints} points.");
                            break;
                        case 666:
                            Console.WriteLine("666. Exit program.");
                            break;
                        default:
                            break;
                    }
                }
  
            } while (validMenuChoice || menuChoice != SentinelFlag);
        }
    }
}