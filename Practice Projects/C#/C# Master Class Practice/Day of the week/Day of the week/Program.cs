Console.WriteLine("Hello, Welcome to the Day of the Week program!");

//ask user for input
Console.WriteLine("Please enter a number from 1 to 7 to find out the day of the week:");

//get user input
int dayNumber = int.Parse(Console.ReadLine());

//output 
Console.WriteLine($"You entered the number: {dayNumber}");


//use switch statement to determine the day of the week
switch (dayNumber)
{
    case 1:
        
        Console.WriteLine("Today is Monday");
        break;

    case 2:
        
        Console.WriteLine("Today is Tuesday");
        break;

    case 3:
        
        Console.WriteLine("Today is Wednesday");
        break;

    case 4:
       
        Console.WriteLine("Today is Thursday");
        break;

    case 5:
        
        Console.WriteLine("Today is Friday");
        break;

    case 6:
        
        Console.WriteLine("Today is Saturday");
        break;

    case 7:
        
        Console.WriteLine("Today is Sunday");
        break;

    default:
        Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
        break;

}

Console.WriteLine("Have a great day!");

