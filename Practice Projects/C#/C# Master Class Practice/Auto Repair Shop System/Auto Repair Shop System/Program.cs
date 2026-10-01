using System.Runtime.InteropServices;

namespace Auto_Repair_Shop_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UpState Auto Repair" + "\n");

            Console.WriteLine("What is your name?: " + "\n");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter Vehicle Year: " + "\n");
            string year = Console.ReadLine();

            Console.WriteLine("Please enter Vehicle Make: " + "\n");
            string make = Console.ReadLine();

            Console.WriteLine("Please enter Vehicle Model: " + "\n");
            string model = Console.ReadLine();

            Console.WriteLine("Are you a returning customer (True/False): " + "\n");
            bool returningCustomer = bool.Parse(Console.ReadLine());
          
            Console.WriteLine("What is the repair cost?: " + "\n");
            double repairCost = double.Parse(Console.ReadLine());

            Console.WriteLine("\n" + "\n");

            Console.WriteLine("Original Price: " + repairCost);

            //call the method
            double finaltotal = CalculateTotal(repairCost, returningCustomer);

            //print the final total
            Console.WriteLine($"{name}");
            Console.WriteLine($"{year}");
            Console.WriteLine($"{make}");
            Console.WriteLine($"{model}");
            Console.WriteLine($"Final Total: {finaltotal}");
        }

        static double CalculateTotal(double repairCost, bool returningCustomer)
        {
            //holds the total
            double total = 0;

            if (returningCustomer)
            { 
                //discount if return customer
                double discount = repairCost * 0.10;

               //get total price
                total = repairCost - discount;

                Console.WriteLine("Returning Customer: " + returningCustomer);
            }
            else
            {

                total = repairCost;

                Console.WriteLine("Returning Customer: " + returningCustomer);
            }

            //returns the total
            return total;
        }

    }
}
