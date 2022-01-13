/* Purpose: To display the name, age, and annual pay
 * 
 * Input:   1) name
 *          2) age
 *          3) annual pay
 * 
 * Output: Displays an output message with the name, age, and annual pay
 */
using System;

namespace SequenceStructureExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name;
            int age;
            double annualPay;

            // Prompt user input and read input values
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your annual salary:");
            annualPay = double.Parse(Console.ReadLine());

            // Display the message
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
        }
    }
}
