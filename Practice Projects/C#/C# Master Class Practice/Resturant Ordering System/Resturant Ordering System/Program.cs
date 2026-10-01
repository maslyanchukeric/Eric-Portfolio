Console.WriteLine("Welcome, To Eric Restaurant!");

//create a menu for the restaurant
Console.WriteLine("**************************** \n");
Console.WriteLine("\tMenu\n");
Console.WriteLine("\t 1. Burger \n");
Console.WriteLine("\t 2. Pizza \n");
Console.WriteLine("\t 3. Pasta \n");
Console.WriteLine("\t 4. Salad \n");
Console.WriteLine("\t 5. Fries \n");
Console.WriteLine("**************************** \n");

//ask the user to select an item from the menu
Console.WriteLine("Please select an item from the menu: \n");

//get the user input
int item = int.Parse(Console.ReadLine());


if (item <= 5)
{
    //create a switch statement to display the selected item
    switch (item)
    {
        case 1:
            Console.WriteLine("You have selected Burger \n");
            break;
        case 2:
            Console.WriteLine("You have selected Pizza \n");
            break;
        case 3:
            Console.WriteLine("You have selected Pasta \n");
            break;
        case 4:
            Console.WriteLine("You have selected Salad \n");
            break;
        case 5:
            Console.WriteLine("You have selected Fries \n");
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
}
else
{
    //display an error message if the user input is invalid
    Console.WriteLine("You entered an invalid selection.");
    return;
}

//ask the user to if they want a drink size
Console.WriteLine("Do you want a drink? (y/n) \n");
string drinkChoice = Console.ReadLine();
string drinkSize;

//check if the user wants a drink
if (drinkChoice == "y")
{
    //ask the user to select a drink size
    Console.WriteLine("\nWhat size drink would you like? (S/M/L) \n");
    drinkSize = Console.ReadLine();

    //check if the drink size is valid
    if (drinkSize == "S" || drinkSize == "M" || drinkSize == "L")
    {
        //display the selected drink size
        Console.WriteLine($"You have selected a {drinkSize} drink.\n");
    }
    else
    {
        //display an error message if the drink size is invalid
        Console.WriteLine("Invalid drink size selection.");
    }

}
else
{
    //display a message if the user does not want a drink
    Console.WriteLine("You selected no drink.\n");
}
