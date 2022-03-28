/* Purpose: Reads an integer between 0 and 1000 and
 *              adds all the digits in the integer
 * 
 * Input: Integer between 0 and 1000
 * 
 * Output: Sum of all inputted digits
 * 
 * Algorith:    Step 1) Prompt and read in the number
 *              Step 2) Extract right most digit from number
 *                      digit1 =  number % 10
 *              Step 3) Extract right most digit from number
 *                      number = number / 10
 *              Step 4) Extract right most digit from number
 *                      digit2 =  number % 10
 *              Step 5) Remoe right most digit from the number
 *                      number = number / 10
 *              Step 6) Extract right most digit from number
 *                      digit3 = number % 10
 *              Step 7) Remove right most digit from the number
 *                      number = number / 10
 *              Step 8) Compute the sum of the digits as follows:
 *                      sum = digit1 + digit2 + digit3
 */
using System;

namespace ExerciseFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user input and read the value
            Console.WriteLine("Enter a number between 0 and 1000:");
            string strInput = Console.ReadLine();
            int tempNum = int.Parse(strInput);
            int sum = 0;

            // Add all the digits in the integer
            for (int i = 0; i < strInput.Length; i++)
            {
                sum = sum + (tempNum % 10);
                tempNum = tempNum / 10;
            }

            // Display the result
            Console.WriteLine($"The sum of the digits is {sum}");
        }
    }
}
