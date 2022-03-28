using System;

namespace ComputeTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxableIncome, taxOwned;
            Console.WriteLine("Enter your taxable income: ");
            taxableIncome = double.Parse(Console.ReadLine());
            Console.Write("Your marginal tax rate is: ");

            if (taxableIncome > 200_000)
            {
                Console.WriteLine("33%");
                taxOwned = 46_317 + 0.33 * (taxableIncome - 200_000);
            }
            else if (taxableIncome > 140_388)
            {
                Console.WriteLine("29%");
                taxOwned = 29_029 + 0.29 * (taxableIncome - 140_388);
            }
            else if (taxableIncome > 90_563)
            {
                Console.WriteLine("26%");
                taxOwned = 16075 + 0.26 * (taxableIncome - 90_563);
            }
            else if (taxableIncome > 45_282)
            {
                Console.WriteLine("20.5%");
                taxOwned = 6792 + 0.205 * (taxableIncome - 45282);
            }
            else
            {
                Console.WriteLine("15%");
                taxOwned = 0.15 * taxableIncome;
            }

            taxOwned = Math.Round(taxOwned, 2);
            Console.WriteLine($"Your approximate federal tax is: {taxOwned:C}");
        }
    }
}
