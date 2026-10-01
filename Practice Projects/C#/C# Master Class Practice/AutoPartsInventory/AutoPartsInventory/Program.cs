using System.Diagnostics.CodeAnalysis;

namespace AutoPartsInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string[] parts = { "Radiator", "Headlight", "Bumper", "Hood" };
            double[] prices = { 250.00, 600.00, 350.00, 500.00 };
            int[] quantites = { 2, 4, 1, 3 };
            double total = 0;

            //loops thru the parts array and displays each part, price, and quantity
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine($"Parts: {parts[i]}");
                Console.WriteLine($"Price: {prices[i]}");
                Console.WriteLine($"Quantity: {quantites[i]}" + "\n");
            }

            total = CalculateInventoryValue(prices, quantites);
        }

        //method to get the price for each item and for total
        static double CalculateInventoryValue(double[] prices, int[] quantities)
        {
            //holds the total price of all inventory
            double total = 0;

            //holds the value of each item
            double result = 0;

            //sum to hold all prices
            double sum = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                //gets the price for the amount of that part
                result = prices[i] * quantities[i];

                sum = sum + result;

                //display the price 
                Console.WriteLine($"Item: {result}, Price: {prices[i]}, Quantity: {quantities[i]}");
            }
            
            total += sum;

            Console.WriteLine($"Total Inventory: {total}");

            return total;
        }
    }
}
