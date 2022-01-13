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

            // Assign values to variables
            name = "Nino Angelo Lumapac";
            age = 31;
            annualPay = 250000.00;

            // Display the message
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
        }
    }
}
