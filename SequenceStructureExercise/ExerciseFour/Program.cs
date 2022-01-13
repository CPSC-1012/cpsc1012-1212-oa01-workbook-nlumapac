/* Purpose: Reads an integer between 0 and 1000 and
 *              adds all the digits in the integer
 * 
 * Input: Integer between 0 and 1000
 * 
 * Output: Sum of all inputted digits
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
