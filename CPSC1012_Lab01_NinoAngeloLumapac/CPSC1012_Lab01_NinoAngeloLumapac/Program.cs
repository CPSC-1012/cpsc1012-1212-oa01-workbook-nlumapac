/* Purpose: To write a program that accepts the retail price of an item
 *          and the quantity being purchased. Then, It will calculate and display the
 *          subtotal of the purchase, provincial sales tax, federal sales tax,
 *          total sales tax and the total sale.
 * 
 * Input:   The price of an item and the quantity being purchased
 * 
 * Output:  Subtotal of the purchase, Provincial sales tax, Federal sales tax,
 *          Total sales tax, and Total of the sale
 *          
 * Algorith:    1) Prompt and read in the values for itemPrice and itemQuantity
 *              2) Compute the subTotal, provincialTax, federalTax, totalTax, and totalPrice
 *                  subTotal = itemPrice * itemQuantity
 *                  provincialTax = subTotal * 0.06
 *                  federalTax = subTotal * 0.05
 *                  totalTax = provincialTax + federalTax
 *                  totalPrice = subTotal + totalTax
 *              3) Display the subTotal, provincialTax, federalTax, totalTax, totalPrice
 *              
 * Test Plan:
 *      Test Case       Test Data           ExpectedResults
 *      ----------      -----------         -------------------
 *      Sample data     itemPrice=6.99      subTotal=13.98
 *                      itemQuantity=2      provincialTax=0.84
 *                                          federalTax=0.70
 *                                          totalTax=1.54
 *                                          totalPrice=15.52
 *                                          
 *      High price      itemPrice=99.99     subTotal=1099.89
 *      High quantity   itemQuantity=11     provincialTax=65.99
 *                                          federalTax=54.99
 *                                          totalTax=120.98
 *                                          totalPrice=1220.87
 * 
 * Written by: Nino Angelo Lumapac
 * 
 * Written for Sam Wu
 * 
 * Section: A01
 */
using System;

namespace CPSC1012_Lab01_NinoAngeloLumapac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the constant variables
            const double ProvincialTaxRate = 0.06;
            const double FederalTaxRate = 0.05;

            // Prompt and read the inputs
            Console.WriteLine("************Welcome to the General Store************");
            Console.Write("Please enter the price of an item: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Please enter the quantity being purchased: ");
            double quantity = double.Parse(Console.ReadLine());

            // Calculate the sub total of purchase
            double subTotal = price * quantity; // --> Math.Round(price * itemQuantity, 2);
            // Calculate the provincial sales tax
            double provincialTax = subTotal * ProvincialTaxRate;    // --> Math.Round(subTotal * ProvincialTaxRate, 2);
            // Calculate the federal sales tax
            double federalTax = subTotal * FederalTaxRate;  // --> Math.Round(subTotal * FederaTaxRate, 2);
            // Calculate the total sales tax
            double totalTax = provincialTax + federalTax;   // --> Math.Round(provincialTax + FederalTaxRate, 2);
            // Calculate the total of the sale
            double totalPrice = subTotal + totalTax;    // --> Math.Round(subTotal + totalTax, 2);

            // Display the results
            Console.WriteLine("Invoice Summary");
            Console.WriteLine("=========================");
            Console.WriteLine($"{"Sub Total:",-16} {subTotal,8:F2}");
            Console.WriteLine("\n");    // --> Console.WriteLine();
            Console.WriteLine($"{"Provincial Tax:",-16} {provincialTax,8:F2}");
            Console.WriteLine($"{"Federal Tax:",-16} {federalTax,8:F2}");
            Console.WriteLine($"{"Total Tax:",-16} {totalTax,8:F2}");
            Console.WriteLine("\n");    // --> Console.WriteLine();
            Console.WriteLine($"{"Total Price:",-16} {totalPrice,8:F2}");
            Console.WriteLine("=========================");
            Console.WriteLine("\n");    // --> Console.WriteLine();
            Console.WriteLine("Thank you for your purchase, come again..");
            Console.WriteLine("Press any key to exit");
        }
    }
}
