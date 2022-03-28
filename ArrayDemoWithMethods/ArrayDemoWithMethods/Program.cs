using System;
using System.IO;

namespace ArrayDemoWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Prompt the user for the number of quick picks
            int numberOfQuickPicks = 0;

            Console.Write("How many quick picks do you want: ");
            numberOfQuickPicks = int.Parse(Console.ReadLine());

            // TODO: Ask the the user if they want to write the numbers to a file.            
            // If user answers yes then prompt for a filename and            
            // write the generate numbers to the filename.
            Console.Write("Would you like to write the numbers to a fiel? [y/n]: ");
            bool writeToFile = char.ToLower( Console.ReadKey().KeyChar) == 'y' ? true : false;

            Console.WriteLine();

            StreamWriter writer = new StreamWriter(@"C:\nait\cpsc1012\QuickPicks.txt");

            // Generate the quick picks
            for (int counter = 1; counter <= numberOfQuickPicks; counter++)
            {
                // TODO: For each quick pick generate 7 random numbers between 1 and 50 by calling
                // the GenerateNumbers methods and write the generated numbers to a text file
                int[] lottoNumberArray = GenerateNumbers(1, 50, 7);
                // Display all the numbers generated
                Console.Write($"Quick Pick #{counter}: ");
                DisplayNumbers(lottoNumberArray);

                if (writeToFile)
                {
                    writer.Write($"Quick Pick #{counter}: ");

                    foreach (int lottoNumber in lottoNumberArray)
                    {
                        writer.Write($"{lottoNumber} ");
                    }

                    writer.WriteLine();
                }
            }

            writer.Close();
        }

        static int[] GenerateNumbers(int minValue, int maxValue, int numberCount)
        {
            // Declare and create a new int array of size numberCount
            int[] numberArray = new int[numberCount];
            // Create a new Random object that we can use to generate
            Random rand = new Random();
            // Assign a random number between minValue and maxValue for each element in the array
            for (int index = 0; index < numberCount ; index++)
            {
                int number = rand.Next(minValue, maxValue + 1);

                if (IsDuplicateNumber(number, numberArray))
                {
                    index--;
                }
                else
                {
                    numberArray[index] = number;
                }
            }
            // Sort the numberArray ascending from smallest to largest
            // Hint: The Array class has a static class-level method for sorting
            Array.Sort(numberArray);

            return numberArray;
        }

        static bool IsDuplicateNumber(int number, int[] numberArray)
        {
            bool isDuplicate = false;

            // Set isDuplicate to true if number is in numberArray
            for (int index = 0; index < numberArray.Length; index++)
            {
                if (numberArray[index] == number)
                {
                    isDuplicate = true;
                    index = numberArray.Length;   // gracefull technique to exit  
                }
            }

            return isDuplicate;
        }

        static void DisplayNumbers(int[] numberArray)
        {
            // Display each element in numberArray,
            // where each element is separated by one empty space
            //Console.Write("The winning lotto numbers are: ");
            //for (int index = 0; index < numberArray.Length; index++)
            //{
            //    Console.Write($"{numberArray[index]} ");
            //}

            foreach (int number in numberArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
