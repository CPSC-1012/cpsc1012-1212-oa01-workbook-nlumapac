using System;

namespace Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int paintChoice;
            //double paintCoverage;


            //paintChoice = double.Parse(Console.ReadLine());

            //switch (paintChoice)
            //{
            //    case 1:
            //        paintCoverage = 100;
            //        break;
            //    case 2:
            //        paintCoverage = 200;
            //        break;
            //    case 3:
            //        paintCoverage = 300;
            //        break;
            //    default:
            //        paintCoverage = 0;
            //        break;
            //}

            //string nickname;
            //Console.Write("Enter your nickname: ");
            //nickname = Console.ReadLine();

            //const double DonationAmount = 1.25;

            //double number;
            //number = double.Parse(Console.ReadLine());

            //double donationAmount;
            //if (donationAmount > 5)
            //{
            //    Console.WriteLine("You are generous.");
            //}
            //else
            //{
            //    Console.WriteLine("Tank your");
            //}

            //*** Question 17
            //string brand = "Motomaster";
            //double price = 9.0;
            //Console.WriteLine($"Brand: {brand}, Price: {price:F2}");

            //*** Question 18
            //int age = 51;
            //if (age < 18)
            //{
            //    Console.WriteLine("Give patient 1 dosage of vaccine.");
            //}
            //else if (age > 50)
            //{
            //    Console.WriteLine("Give patient 3 dosage of vaccine.");
            //}
            //else
            //{
            //    Console.WriteLine("Give patient 2 dosage of vaccine.");
            //}

            //*** Question 19
            //int menuChoice =5;
            //if (menuChoice < 0 || menuChoice > 4)
            //{
            //    Console.WriteLine("Invalid menu selection");
            //}

            //*** Question 20
            //int metalChoice;
            //string inputValue = Console.ReadLine();
            //metalChoice = int.Parse(inputValue);

            //*** Question 21
            int metalChoice = 500;
            if (metalChoice != 1 ^ metalChoice != 2 ^ metalChoice != 666)
            {
                Console.WriteLine("Invalid metal selection.");
            }
        }
    }
}
