using System.Runtime.InteropServices;

Random random = new Random();

int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 0;

Console.WriteLine("Guess the Number, Im thinking of a number from 1-100");

while(userGuess != secretNumber)
{
    Console.WriteLine("Enter your guess");
    userGuess = int.Parse(Console.ReadLine());

    if(userGuess < secretNumber)
    {
        Console.WriteLine("guess is too low");
    }
    else if(userGuess > secretNumber)
    {
        Console.WriteLine("guess was too high");
    }
    else
    {
        Console.WriteLine("you guessed it right" + " it took you " + counter + " tries");
    }

    counter++;
}


