//user enters a number
Console.WriteLine("Please Enter a number: ");

//get users input
double num1 = double.Parse(Console.ReadLine());

//user enters a another number
Console.WriteLine("Please Enter another number: ");

//get users input
double num2 = double.Parse(Console.ReadLine());

//get sum, difference, product, and quotient
double sum = num1 + num2;
double difference = num1 - num2;
double product = num1 * num2;
double quotient = Math.Round(num1 / num2, 2);

//output results
Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
Console.WriteLine($"The difference of {num1} and {num2} is: {difference}");
Console.WriteLine($"The product of {num1} and {num2} is: {product}");
Console.WriteLine($"The quotient of {num1} and {num2} is: {quotient}");
