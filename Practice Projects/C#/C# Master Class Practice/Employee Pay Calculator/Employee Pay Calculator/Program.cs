namespace Employee_Pay_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user for name, hours worked, and pay
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Hours Worked: ");
            double hoursWorked = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Hourly Pay: ");
            double pay = double.Parse(Console.ReadLine());

            CalculatePay(hoursWorked, pay);

        }

        static void CalculatePay(double hoursWorked, double pay)
        {
            double regularPay;
            double totalPay = 0;
            double extraPay = 0;

            if (hoursWorked > 40)
            {
                //regular pay 
                regularPay = 40 * pay;

                //get the overtime
                double overtime = hoursWorked - 40 ;

                //get overtime pay 
                double overTimePay = pay * 1.5;

                //add the overtime and the overtime pay
                extraPay = overtime * overTimePay;

                //add to the regular time
                regularPay += extraPay;

                //give the regular pay to total
                totalPay = regularPay;

                //show info
                Console.WriteLine($"Worked Hours: {hoursWorked}");
                Console.WriteLine($"Pay: {pay}");
                Console.WriteLine($"Overtime: {overtime}");
                Console.WriteLine($"Overtime Pay: {extraPay}");
                Console.WriteLine($"Total Pay: {totalPay}");
            }
            else if(hoursWorked >= 0)
            {
                //40 or lower its regular pay
                totalPay = hoursWorked * pay;
                Console.WriteLine($"Worked Hours: {hoursWorked}");
                Console.WriteLine($"Pay {pay}");
                Console.WriteLine($"Total Pay: {totalPay}");
            }
            else
            {
                Console.WriteLine("You didnt work this week");
            }
        }
    }
}
