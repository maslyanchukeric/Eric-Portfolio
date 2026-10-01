namespace Auto_Repair_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables for the repair job
            double discount;
            string newJob = "";

            //create the list of repair jobs and add the new job to the list
            List<RepairJob> repairJobs = new List<RepairJob>();

            //loop to allow the user to enter multiple repair jobs
            while (newJob != "no")
            {
                //Ask user for the customer's name
                Console.WriteLine("Please enter the your name:");
                string customerName = Console.ReadLine().Trim();

                //Ask user for the vehicle make and model
                Console.WriteLine("Please enter the vehicle make and model:");
                string vehicle = Console.ReadLine().Trim();

                //Ask user for the type of repair needed
                Console.WriteLine("Please enter the type of repair needed:");
                string repairType = Console.ReadLine().Trim();

                //Ask user for the number of labor hours required
                Console.WriteLine("Please enter the number of labor hours required:");
                int laborHours;
                while (!int.TryParse(Console.ReadLine(), out laborHours))
                {
                    Console.WriteLine("Invalid input. Enter labor hours again: ");
                }

                //Ask user for the hourly rate
                Console.WriteLine("Please enter the hourly rate:");
                int hourlyRate;
                while (!int.TryParse(Console.ReadLine(), out hourlyRate))
                {
                    Console.WriteLine("Invalid input. Enter hourly rate again: ");
                }

                //Ask user for the cost of parts
                Console.WriteLine("Please enter the cost of parts:");
                decimal partsCost;
                while (!decimal.TryParse(Console.ReadLine(), out partsCost))
                {
                    Console.WriteLine("Invalid input. Enter cost of parts again: ");
                }

                //Ask user if they are returing customer and if they are, ask for the discount percentage
                Console.WriteLine("Are you a returning customer? (yes/no)");
                string returningCustomer = Console.ReadLine().Trim().ToLower();

                if (returningCustomer == "yes")
                {
                    discount = 10;
                }
                else
                {
                    discount = 0;
                }

                //Create a new RepairJob object with the user's input
                RepairJob job = new RepairJob(customerName, vehicle, repairType, laborHours, hourlyRate, partsCost);

                //Calculate the total cost of the repair job with the discount
                decimal totalCost = job.CalculateTotal(discount);
                job.TotalCost = totalCost;

                //Add to the list of repair jobs
                repairJobs.Add(job);

                //Ask user to the see the list of repair jobs and display the list if they want to see it
                Console.WriteLine("Would you like to see the list of repair jobs? (yes/no)");
                string seeList = Console.ReadLine().Trim().ToLower();
                if (seeList == "yes")
                {
                    foreach (RepairJob repairJob in repairJobs)
                    {
                        Console.WriteLine($"Customer Name: {repairJob.CustomerName}, " +
                            $"Vehicle: {repairJob.Vehicle}, " +
                            $"Repair Type: {repairJob.RepairType}, " +
                            $"Labor Hours: {repairJob.LaborHours}, " +
                            $"Hourly Rate: {repairJob.HourlyRate}, " +
                            $"Parts Cost: {repairJob.PartsCost}, " +
                            $"Total Cost: {repairJob.TotalCost}");
                    }

                }

                //Ask user if they would like to add another repair job
                Console.WriteLine("Would like to add another job? (yes/no)");
                newJob = Console.ReadLine().Trim().ToLower();
            }

            //Thank the user for using the program
            Console.WriteLine("Thank you for using the Auto Repair Shop program!");
        }
    }
}

