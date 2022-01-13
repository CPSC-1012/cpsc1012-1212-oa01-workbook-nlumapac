using System;

namespace IntegerVariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int checking;   //Declare an int variable named checking
            long days;      //Declare a long variable named days

            checking = -20;
            days = 189000;

            Console.WriteLine($"Our account balance is {checking}");
            Console.WriteLine($"About {days} days ago Columbus stood in this spot.");
        }
    }
}
