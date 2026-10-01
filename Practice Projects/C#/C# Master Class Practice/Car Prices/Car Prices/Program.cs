namespace Car_Prices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of car prices
            List<int> Prices = new List<int> { 45000, 25000, 60000, 18000, 35000 };

            // Sort the list of prices in ascending order
            Prices.Sort();

            // Loop through the sorted list and print each price
            foreach(int price in Prices)
            {
               if(price >= 30000)
               {
                    Console.WriteLine($"{price}");
               }
                
            }
        }
    }
}
