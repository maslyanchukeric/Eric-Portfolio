string correctUsername = "Eric";
string correctPassword = "1234";

//ask the user for their username and password
Console.WriteLine("Please enter Username: ");

//user input for username and password
string username = Console.ReadLine();

//ask user for the password
Console.WriteLine("Please enter Password: ");

//user input for username and password
string password = Console.ReadLine();

//check the username and password are correct
if(username == correctUsername && password == correctPassword)
{
    Console.WriteLine("Access granted.");
}
else if(username == correctUsername && password != correctPassword)
{
    Console.WriteLine("Password is incorrect.");
}
else 
{
    Console.WriteLine("Username not found.");
}
