//ask the user how they are 
Console.WriteLine("What is your age?");

//ask the user to input their age
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Are your Parents with you? (true/false)");
bool withParents = bool.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Here is your Adult ticket!");
} 
else if (age >= 13 && withParents)
{
    Console.WriteLine("Here is your Youth ticket!");
}
else
{
    Console.WriteLine("Here is your Child ticket!");
}
