//ask for the age 
Console.WriteLine("What is your age?");
int age = int.Parse(Console.ReadLine());

//ask for the height in inches
Console.WriteLine("What is your height in inches?");
double height = double.Parse(Console.ReadLine());

//ask for if parent is present
Console.WriteLine("Is a parent present? (true/false)");
bool parentPresent = bool.Parse(Console.ReadLine());

//check if person can ride the ride
if (age >= 12 && height >= 54)
{
    Console.WriteLine("You can ride the ride!");
}
else if (age >= 10 && parentPresent)
{
    Console.WriteLine("You can ride the ride with a parent!");
}
else
{
    Console.WriteLine("You cannot ride the ride.");
}