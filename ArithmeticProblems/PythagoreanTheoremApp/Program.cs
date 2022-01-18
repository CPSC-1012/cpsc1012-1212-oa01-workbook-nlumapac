/* Purpose: To write a program that solve the hypotenuse of a right triangle by supplying
 *          the height and base of a right triangle
 * 
 * Input: height, base
 * 
 * Output: hypotenuse
 * 
 * Written by: Nino Angelo Lumapac
 * 
 * Written for: Sam Wu
 * 
 * Section: A01
 */
using System;

namespace PythagoreanTheoremApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user input and read the value
            Console.Write("Enter the height of the right triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the base of the right triangle: ");
            double b = double.Parse(Console.ReadLine());

            // Calculate the hypotenuse
            double c = Math.Sqrt((a * a) + (b * b));

            // Display the result
            Console.WriteLine($"The hypotenuse is {c}");
        }
    }
}
