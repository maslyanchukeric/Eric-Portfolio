namespace Add_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list of cars
            List<string> Cars = new List<string>();

            //add cars to the list
            Cars.Add("BMW");
            Cars.Add("Audi");
            Cars.Add("Ford");
            Cars.Add("Toyota");

            int carCount = Cars.Count;

            //display the list of cars
            Console.WriteLine($"Number of Cars: {carCount}");

            foreach(string car in Cars)
            {
                Console.WriteLine(car);
            }


        }
    }
}
