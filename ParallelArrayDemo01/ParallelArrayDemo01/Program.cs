using System;
namespace ParallelArrayDemo01
{
    internal class Program
    {
        // Create a method that is passed in the array of student names and array of student marks        
        // and it will print the name of mark of each student
        static void PrintStudentMarks(string[] nameArray, double[] markArray, int studentCount)
        {
            Console.WriteLine($"{"Student Name", -25} {"Mark", 4}");
            Console.WriteLine($"{"------------", -25} {"----",4}");
            for (int index = 0; index<studentCount; index++)
            {
                Console.WriteLine($"{nameArray[index], -25} {markArray[index], 4}");
            }
        }

        // TODO 1: Add a method to sort the array by name
        static void SortByName(string[] nameArray, double[] markArray, int studentCount)
        {
            for (int firstLoopIndex = 0; firstLoopIndex < studentCount; firstLoopIndex++)
            {
                for (int secondLoopIndex = 0; secondLoopIndex < studentCount - 1; secondLoopIndex++)
                {
                    if (nameArray[secondLoopIndex].CompareTo(nameArray[secondLoopIndex + 1]) > 0)
                    {
                        string tempName = nameArray[secondLoopIndex];
                        nameArray[secondLoopIndex] = nameArray[secondLoopIndex + 1];
                        nameArray[secondLoopIndex + 1] = tempName;

                        double tempMark = markArray[secondLoopIndex];
                        markArray[secondLoopIndex] = markArray[secondLoopIndex + 1];
                        markArray[secondLoopIndex + 1] = tempMark;
                    }
                }
            }
        }

        // TODO 2: Add a method to sort the arrays by mark descending
        static void SortByMarkDescending(string[] nameArray, double[] markArray, int studentCount)
        {
            for (int firstLoopIndex = 0; firstLoopIndex < studentCount; firstLoopIndex++)
            {
                for (int secondLoopIndex = 0; secondLoopIndex < studentCount - 1; secondLoopIndex++)
                {
                    if (markArray[secondLoopIndex] < markArray[secondLoopIndex + 1])
                    {
                        string tempName = nameArray[secondLoopIndex];
                        nameArray[secondLoopIndex] = nameArray[secondLoopIndex + 1];
                        nameArray[secondLoopIndex + 1] = tempName;

                        double tempMark = markArray[secondLoopIndex];
                        markArray[secondLoopIndex] = markArray[secondLoopIndex + 1];
                        markArray[secondLoopIndex + 1] = tempMark;
                    }
                }
            }
        }

        // TODO 3: Add a method to find the index of the student with the highest mark(if there is a tie, return the first)
        static int IndexOfHighestMark(double[] markArray, int studentCount)
        {
            int highestIndex = 0;
            // Assume the first element contains the highest mark
            double highestMark = markArray[highestIndex];
            for (int index = 1; (index<studentCount); index++)
            {
                // Check if the current mark is greater the current highest mark
                if (markArray[index] > highestMark)
                {
                    // Assign the current mark as the highest mark
                    highestMark = markArray[index];
                    // Assign the current index as the new highest index
                    highestIndex = index;
                }
            }
            return highestIndex;
        }

        // TODO 4: Add a method to return the average mark in class
        static double AverageMark(double[] markArray, int studentCount)
        {
            double average = 0;
            double sumMarks = 0;

            for (int index = 0; index<studentCount; index++)
            {
                sumMarks += markArray[index];
            }

            average = sumMarks / studentCount;

            return average;
        }

        // TODO 5: Add a method display the name and mark of the student with the highest mark
        static void PrintStudentWithHighestMark(string[] nameArray, double[] markArray, int studentCount)
        {
            // Determine which student has the highest mark
            int indexOfHighestValue = IndexOfHighestMark(markArray, studentCount);
            Console.Write($"The student with the highest mark: ");
            Console.WriteLine($"{nameArray[indexOfHighestValue]} with a mark of {markArray[indexOfHighestValue]}");
        }

        // TODO 6: Add a method that read from a file a list of student name and student marks
        static void Main(string[] args)
        {
            // Declare a constant for size of the arrays
            const int ArraySize = 5;
            // Declare and create a new array of string of size ArraySize for student names
            string[] studentNameArray = new string[ArraySize];
            // Delcare and create a new array of double of size ArraySize for student marks
            double[] studentMarkArray = new double[ArraySize];

            // Declare a variable to count the number of students in the class
            int studentCount = 0;

            // Ask the user for the number of students in the class
            Console.Write($"How many students are in the class? (<= {ArraySize}) ");
            studentCount = int.Parse(Console.ReadLine());
            if (studentCount <= ArraySize)
            {
                // Ask the user to enter the name and mark for each student in the class
                for (int index = 0; index < studentCount; index++)
                {
                    // Ask the user to enter the student name
                    Console.Write("What is the student name? ");
                    studentNameArray[index] = Console.ReadLine();
                    // Ask the user to enter the student mark
                    Console.Write($"What is {studentNameArray[index]} mark?");
                    studentMarkArray[index] = double.Parse(Console.ReadLine());
                }

                SortByMarkDescending(studentNameArray, studentMarkArray, studentCount);

                // Call the PrintStudetMarks method
                PrintStudentMarks(studentNameArray, studentMarkArray, studentCount);
            }
            else
            {
                Console.WriteLine($"This program does not support more than {ArraySize} students.");
                Console.WriteLine($"Upgrade to the PAID version for to handle more than {ArraySize} students.");
            }
        }
    }
}