int[] numbers = { 4, 7, 12, 3, 20, 9, 16 };

int evenCount = 0;
//goes thru it element
foreach(var num in numbers)
{
    //check if the number is even 
    if(num % 2 == 0)
    {
        Console.WriteLine(num + " is even");
        evenCount++;
    }
    else
    {
        Console.WriteLine(num + " is odd");
    }
}

Console.WriteLine("Even Count: " + evenCount);
