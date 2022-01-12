/* Purpose: Compute the weekly wage of an employee.
 * 
 * Inputs:  1) regular hourly rate
 *          2) regular hours worked
 *          3) overtime hourly rate
 *          4) overtime hours worked
 *          
 * Outputs: 1) regular wages
 *          2) overtime wages
 *          
 * Algorithm:   Step 1: Prompt for regular hourly rate,
 *                      regular hours worked,
 *                      overtime hourly rate,
 *                      overtime hours worked
 *              Step 2: Compute the following values:
 *                      regularWages =  regularHourlyRate * regularHoursWorked
 *                      overtimeWages = overtimeHourlyRate * overtimeHoursWorked
 *                      totalWages = regularWages + overtimeWages
 *              Step 3: Display the wages for the week
 */
using System;

namespace WagesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double regularWages; // The calculated regular wages
            double overtimeWages; // Overtime wages
            double totalWages; // Total wages

            // Prompt and read the input for base pay
            Console.Write("Enter the base pay: $");
            double basePay = double.Parse(Console.ReadLine());

            // Prompt and read the input for regular hours
            Console.Write("Enter the regular hours: ");
            double regularHours = double.Parse(Console.ReadLine());

            // Prompt and read the input for overtime pay
            Console.Write("Enter the overtime pay: $");
            double overtimePay = double.Parse(Console.ReadLine());

            // Prompt and read the input for overtime hours
            Console.Write("Enter the overtime hours: ");
            double overtimeHours = double.Parse(Console.ReadLine()); ; 
            
            // Compute wage
            regularWages = basePay * regularHours;
            overtimeWages = overtimePay * overtimeHours;
            totalWages = regularWages + overtimeWages;

            // Display wage
            Console.WriteLine($"Wages for this week are {totalWages:C}");
        }
    }
}
