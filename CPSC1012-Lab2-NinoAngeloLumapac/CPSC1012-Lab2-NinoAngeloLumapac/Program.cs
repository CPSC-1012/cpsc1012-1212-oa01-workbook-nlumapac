/* Purpose: To write a program that allows the user to choose from the following conversions:
 *              1) Inches to Centimeters
 *              2) Yards to Meters
 *              3) Miles to Kilometers
 * 
 * Input:   1) The menu choices from 1, 2, 3, 4 or an invalid menu choice
 *          2) The value to be converted based on selected conversion
 * 
 * Output:  1) The converted value of the selected conversion
 *          2) Or, a message for invalid menu choice
 *          
 * Algorithm:   1) Prompt and read in the selected menu
 *              2) Use conditions to convert the value based on the selected conversion 
 *                  For inches to centimeters, result =  enteredValue * 2.54
 *                  For yards to meters, result =  enteredValue * 0.9144
 *                  For miles to kilometers, result =  enteredValue * 1.60934
 *                  For exit, display message "Exit, Good Bye..."
 *                  For invalid input, display message "INVALID Selection, Good Bye..."
 *              3) Display the result and/or the message
 * 
 * Author: Nino Angelo Lumapac
 * 
 * Last Modified Date: 2022-01-26
 * 
 * Written for: Sam Wu
 * 
 * Section: A01
 */
using System;

namespace CPSC1012_Lab2_NinoAngeloLumapac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the constant variables
            const double InchToCentimeter = 2.54;
            const double YardToMeter = 0.9144;
            const double MileToKilometer = 1.60934;

            // Declare the user variables
            string menu = "";
            double enteredValue = 0;
            double result = 0;

            // Prompt and read the selected menu
            Console.WriteLine("*********************Conversion Calculator*********************");
            Console.WriteLine("Please choose from the following menu");
            Console.WriteLine("\t1)Inches to Centimeters");
            Console.WriteLine("\t2)Yards to Meters");
            Console.WriteLine("\t3)Miles to Kilometers");
            Console.WriteLine("\t4)Exit");
            Console.Write("\tSelecton ?");

            menu = Console.ReadLine();

            if (menu == "1")    // Convert inches to centimeters menu
            {
                // Prompt and read the input
                Console.Write("Please enter value in inches: ");
                enteredValue = double.Parse(Console.ReadLine());

                // Calculate inches to centimeters
                result = enteredValue * InchToCentimeter;

                // Display converted value and message
                Console.WriteLine($"The value of {enteredValue:F2} inches is {result:F2} cm.");
                Console.WriteLine("Good Bye..");
            }
            else if (menu == "2")   // Convert yards to meters menu
            {
                // Prompt and read the input
                Console.Write("Please enter value in yards: ");
                enteredValue = double.Parse(Console.ReadLine());

                // Calculate yards to meters
                result = enteredValue * YardToMeter;

                // Display converted value and message
                Console.WriteLine($"The value of {enteredValue:F2} yards is {result:F2} meters.");
                Console.WriteLine("Good Bye..");
            }
            else if (menu == "3")   // Convert miles to kilometers menu
            {
                // Prompt and read the input
                Console.Write("Please enter value in miles: ");
                enteredValue = double.Parse(Console.ReadLine());

                // Calculate miles to kilometers
                result = enteredValue * MileToKilometer;

                // Display converted value and message
                Console.WriteLine($"The value of {enteredValue:F2} miles is {result:F2} km.");
                Console.WriteLine("Good Bye..");
            }
            else if (menu == "4")   // Exit menu
            {
                // Display message
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Exit, Good Bye...");
            }
            else    // Invalid selection
            {
                // Display message
                Console.WriteLine("INVALID Selection, Good Bye...");
            }
        }
    }
}
