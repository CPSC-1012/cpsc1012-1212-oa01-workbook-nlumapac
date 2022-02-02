using System;

namespace Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TotalNumberOfStudents = 10;

            int numberOfStudents = 0;
            int passOrFail = 0;
            int totalPassed = 0;
            int totalFailed = 0;

            while (numberOfStudents < TotalNumberOfStudents)
            {
                Console.Write("Enter result (1=pass, 2=fail): ");
                passOrFail = int.Parse(Console.ReadLine());

                switch (passOrFail)
                {
                    case 1:
                        totalPassed++;
                        break;
                    case 2:
                        totalFailed++;
                        break;
                    default:
                        break;
                }

                numberOfStudents++;
            }

            Console.WriteLine("");
            Console.WriteLine($"Passed: {totalPassed}");
            Console.WriteLine($"Failed: {totalFailed}");
        }
    }
}
