/* Purpose: Compute the total of a sales item using the price and tax.
 * 
 * Inputs: Price in dollar and cents
 * 
 * Outputs: Sales total
 * 
 * Algorithm:   Step 1) Prompt and read the sale price
 *              Step 2) Calculate the sale total using the formula:
 *                      saleTotal = salePrice + salesTax
 *                      where salesTax = salePrice * 0.05
 *              Step 3) Display the computed sale total
 *              
 * Last Modified: 2022-01-12
 */
using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tax Rate
            const double taxRate = 0.05;

            // Declare variables
            string inputPrice;
            double tax, price, total;

            // Read the input
            Console.Write($"Input price: ");
            inputPrice = Console.ReadLine();
            price = double.Parse(inputPrice);

            // Calculate tax
            tax = price * taxRate;
            // Calculate total
            total = price + tax;

            // Display result
            Console.WriteLine($"The price of the item is: {price:C}");
            Console.WriteLine($"The tax is {tax:C}");
            Console.WriteLine($"The total is {total:C}");
        }
    }
}
