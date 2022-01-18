/* Purpose: To calculate the sum of the digits of a three-digit whole number
 * 
 * Input: three-digit whole number
 * 
 * Output: sum of the digits of the number
 * 
 * Written by: Nino Angelo Lumapac
 * 
 * Written for: Sam Wu
 * 
 * Section: A01
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
 *              Step 7) Compute the sum of the digits as follows:
 *                      sum = digit1 + digit2 + digit3
 *              Step 8) Display result
 */
using System;

namespace SumOfDigitsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1) Prompt and read in the number
            Console.Write("Enter a three-digit whole number: ");
            int number = int.Parse(Console.ReadLine());
            // Step 2) Extract right most digit from number
            int digit1 = number % 10;
            // Step 3) Extract right most digit from number
            number = number / 10;
            // Step 4) Extract right most digit from number
            int digit2 = number % 10;
            // Step 5) Remoe right most digit from the number
            number = number / 10;
            // Step 6) Extract right most digit from number
            int digit3 = number % 10;
            // Step 7) Compute the sum of the digits
            int sum = digit1 + digit2 + digit3;
            // Step 8) Display result
            Console.WriteLine($"The sum of the digits is: {sum}");
        }
    }
}
