using System;

namespace CheckLeapYearApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year to check if it is a Leap Year: ");
            int inputYear = int.Parse(Console.ReadLine());

            if (((inputYear % 4 == 0) && (inputYear % 100 != 0)) || (inputYear % 400 == 0))
            {
                Console.WriteLine($"{inputYear} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{inputYear} is not a Leap Year.");
            }
        }
    }
}
