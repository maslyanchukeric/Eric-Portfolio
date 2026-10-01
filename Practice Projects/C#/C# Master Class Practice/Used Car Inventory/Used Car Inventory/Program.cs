using System.Runtime.ConstrainedExecution;

namespace Used_Car_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string newCar = "";
            string year = "";
            string make = "";
            string model = "";
            int mileage = 0;
            double price = 0;

            //make a car object
            Car car = new Car(year, make, model, mileage, price);

            //title
            Console.WriteLine("Used Car Inventory!" + "\n");

            List<Car> cars = new List<Car>();

            do
            {
                //User to enter the car info
                Console.WriteLine("Enter Year: ");
                year = Console.ReadLine();

                Console.WriteLine("Enter Make: ");
                make = Console.ReadLine();

                Console.WriteLine("Enter Model: ");
                model = Console.ReadLine();

                Console.WriteLine("Enter Mileage: ");
                mileage = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price: ");
                price = double.Parse(Console.ReadLine());

                //create a new car
                car = new Car(year, make, model, mileage, price);

                //add to the list
                cars.Add(car);

                Console.WriteLine("Would like to enter a new car: Please enter yes or no");
                newCar = Console.ReadLine().Trim().ToLower();

            } while (newCar == "yes");

            foreach (Car c in cars)
            {
                c.DisplayInfo();
            }
        }
    }
}
