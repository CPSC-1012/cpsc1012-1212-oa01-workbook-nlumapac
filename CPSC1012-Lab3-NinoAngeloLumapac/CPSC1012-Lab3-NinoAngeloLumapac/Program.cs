/* Purpose: To write a program that prints out a Teaspoons to Tablespoons table
 *          in increments entered by user from 1 to 20. The increment value is 
 *          checked if it is a positive number otherwise repeatedly ask to enter a
 *          positive value. The program exits until the user would like to exit.
 * 
 * Input:   1) increment number between 1 to 20
 *          2) sentinel flag [y/Y] - to exit the program
 * 
 * Output:  1) teaspoons to tablespoons table where teaspoons ranges between 1 to 20
 * 
 * Algorithm:   1) Prompt and read the entered increment value
 *              2) Check if the increment value is valid (must be positive number and the number ranges from 1 to 20)
 *              2) Calculate the teaspoons to tablespoons using the below formula:
 *                  tablespoon = teaspoon * (1.0 / 3.0);
 *              3) Display the result teaspoons to tablespoons table
 *              4) Prompt user to repeat the program or exit otherwise
 *              
 * Author: Nino Angelo Lumapac
 * 
 * Last Modified Date: 2022-02-10
 * 
 * Written for: Sam Wu
 * 
 * Section: A01
 */
using System;

namespace CPSC1012_Lab3_NinoAngeloLumapac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare constant variables
            const int MinTeaspoon = 1;
            const int MaxTeaspoon = 20;

            //Declare user variables
            char runAgainFlag = 'n';

            bool validRunAgain;
            bool validIncrement;

            int increment = 0;
            double tablespoon;

            do
            {
                validRunAgain = false;
                validIncrement = false;

                Console.WriteLine("**********Conversion Table**********");
                
                validIncrement = false;
                while (!validIncrement)
                {
                    //Prompt and read the increment value
                    //Added more info in the prompt to be more user friendly, since the requirement only process teaspoons from 1 to 20
                    Console.Write("Please enter the increment to be used for your table (must be positive and between 1 to 20): ");
                    validIncrement = int.TryParse(Console.ReadLine(), out increment);

                    //Check if the entered increment is valid
                    if (validIncrement && (increment >= MinTeaspoon && increment <= MaxTeaspoon))
                    {
                        validIncrement = true;
                    }
                    else
                    {
                        validIncrement = false;
                        //Added more info in the prompt to be more user friendly, since the requirement only process teaspoons from 1 to 20
                        Console.WriteLine("Invalid increment. Please enter a positive number and between 1 to 20.");
                    }
                }

                //Display teaspoons to tablespoons header
                Console.WriteLine("Tea Spoons Table Spoons");
                Console.WriteLine("========== ============");

                //Calculate and display tablespoons table in increments
                for (int teaspoon = MinTeaspoon; teaspoon <= MaxTeaspoon; teaspoon += increment)
                {
                    tablespoon = teaspoon * (1.0 / 3.0);
                    tablespoon = Math.Round(tablespoon, 2);
                    Console.WriteLine($"{teaspoon,10:F2} {tablespoon,12:F2}");
                }

                //Prompt and read if the user wants to run the program again
                Console.Write("Would you like to run the program again (Y-Yes): ");
                validRunAgain = char.TryParse(Console.ReadLine(), out runAgainFlag);

                //Check if the entered runFlag is valid
                if (validRunAgain && (runAgainFlag == 'y' || runAgainFlag == 'Y'))
                {
                    validRunAgain = true;
                    Console.WriteLine();
                }
                else
                {
                    validRunAgain = false;
                }

            } while (validRunAgain);    //Repeat OR Exit program
            
        }
    }
}
