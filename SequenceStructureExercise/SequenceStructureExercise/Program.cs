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
