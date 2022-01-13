/* Purpose: Computes the area and volume
 * 
 * Input:   1) radius
 *          2) length
 * 
 * Output:  1) area
 *          2) volume
 */
using System;

namespace ExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user 
            Console.WriteLine("Enter the radius and length of a cylinder:");

            // Assign input values to variable
            double radius = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            // Calculate area
            double area = (radius * radius) * Math.PI;
            // Calculate volume
            double volume = area * length;

            // Display result
            Console.WriteLine($"The area is {area:0.####}");
            Console.WriteLine($"The volume is {volume:0.#}");
        }
    }
}
