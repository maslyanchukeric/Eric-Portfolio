//welcome message
Console.WriteLine("Hello, Welcome to Grade Checker!");

//user enter their grade
Console.WriteLine("Please enter your grade (0-100):");

//holds the grade value
int grade = int.Parse(Console.ReadLine());

//display the grade entered
Console.WriteLine($"Grade entered: {grade}");

//check the grade
if(grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid grade entered. Please enter a grade between 0 and 100.");
}
else if (grade >= 90 && grade <= 100)
{
    Console.WriteLine("You got an A!");
}
else if (grade >= 80)
{
    Console.WriteLine("You got a B!");
}
else if (grade >= 70)
{
    Console.WriteLine("You got a C!");
}
else if (grade >= 60)
{
    Console.WriteLine("You got a D!");
}
else
{
    Console.WriteLine("You got an F!");
}

Console.WriteLine("Thank you for using Grade Checker! Goodbye!");
