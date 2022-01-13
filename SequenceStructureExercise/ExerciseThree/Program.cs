/* Purpose: Computes the area of a hexagon
 * 
 * Input: Side of a hexagon
 * 
 * Output: Area
 */
using System;

namespace ExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user and read the value
            Console.WriteLine("Enter the length of the side:");
            double s = double.Parse(Console.ReadLine());

            // Calculate the area
            double area = (3 * Math.Sqrt(3) * Math.Pow(s,2))/2;

            // Display the area
            Console.WriteLine($"The area of the hexagon is {area:0.####}");
        }
    }
}
