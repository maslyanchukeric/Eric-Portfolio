string rocket = @"
        ^
       /^\
       |-|
       | |
       |N|
       |A|
       |S|
       |A|
      /| |\
     /_|_|_\
       / \
      /   \
     |     |
     |     |
     |_____|
";

Console.WriteLine(rocket);

for (int i = 10; i >= 0; i--) 
{
    //clears the console and prints the rocket and countdown
    Console.Clear();
    Console.WriteLine($"Countdown: {i}");
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket; //adds a new line to the rocket string to simulate movement"
    Thread.Sleep(1000);
}
Console.WriteLine("Woohhoo! The rocket has landed successfully!");