import java.util.Scanner;
public class ArithmeticDemo2 
{

	public static void main(String[] args) 
	{
		//variables 
		double firstNumber;
		double secondNumber;
		double sum;
		double difference;
		double average;
		
		//create a scanner
		Scanner input = new Scanner(System.in);
		
		
		//prompt the user for second number
		System.out.println("Please enter an double");
		firstNumber = input.nextDouble();
		
		System.out.println("Please enter an another double");
		secondNumber = input.nextDouble();
		
		sum = firstNumber + secondNumber;
		difference = firstNumber - secondNumber;
		average = sum / 2;
		
		System.out.println(firstNumber + " + " + secondNumber + " is " + sum); 
		
		System.out.println(firstNumber + " - " + secondNumber + " is " + difference);
		
		System.out.println("The average of " + firstNumber + " and " + secondNumber + " is " + average);
	}

}
