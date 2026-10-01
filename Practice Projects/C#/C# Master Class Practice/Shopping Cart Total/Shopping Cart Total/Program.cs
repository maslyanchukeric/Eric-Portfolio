//array of prices
double[] prices = { 12.99, 5.50, 20.00, 3.25, 8.75 };

//variable that hold the total price 
double total = 0;


//counter that count price over 10$
int counter = 0;

foreach(var price in prices)
{
    //print the price 
    Console.WriteLine("Price: " + price);

    if(price >= 10.00)
    {
        counter++;
    }

    //add the up all the prices
    total += price;
}

//display the total and the counter
Console.WriteLine("\nTotal is: " + total + "\n");
Console.WriteLine("Prices 10$ or more: " + counter);