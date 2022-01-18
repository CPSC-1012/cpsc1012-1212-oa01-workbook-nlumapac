/* Purpose: To write a program that acccepts three real numbers and computes their mean average
 * 
 * Input: number1, number2, number3
 * 
 * Output: mean average
 * 
 * Written by: Nino Angelo Lumapac
 * 
 * Written for: Sam Wu
 * 
 * Section: A01
 */
using System;

namespace ComputeAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Input three real numbers:");

            // Read user inputs
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            // Compute average
            double average = (number1 + number2 + number3) / 3;

            // Display result
            Console.Write($"The average is {average:F2}");
        }
    }
}
