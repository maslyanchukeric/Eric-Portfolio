namespace Favorite_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of favorite cars
            List<string> cars = new List<string>() {"BMW", "Audi", "Toyota"};

            //loop through the list and print each car
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
