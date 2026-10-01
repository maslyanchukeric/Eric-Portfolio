namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop example
            int number = 0;
            
            while (number <= 5)
            {
                Console.WriteLine(number);
                number++;
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Password checker
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            while(password != "BMW123")
            {
                Console.WriteLine("Incorrect Password. Please try again.");
                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Access granted.");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //age checker
            Console.WriteLine("Enter your age: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int age);
            while (!isNumber || age < 1 || age > 100)
            {
                Console.WriteLine("Invalid age. Please enter a valid age between 1 and 100.");
                isNumber = int.TryParse(Console.ReadLine(), out age);
            }

            Console.WriteLine($"Your age is {age}.");

        }
    }
}
