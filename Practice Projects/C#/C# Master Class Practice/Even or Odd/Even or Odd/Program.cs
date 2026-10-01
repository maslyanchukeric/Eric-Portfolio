//ask user for a number 
Console.WriteLine("Please enter a number:");
int number = int.Parse(Console.ReadLine());

//variable is even and check if the number is even or odd
bool isEven = number % 2 == 0;

//output result
Console.WriteLine($"The number you entered is {number}\n");
Console.WriteLine($"Is it even? {isEven}");


