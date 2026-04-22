import java.util.Scanner;
public class ArithmeticDemo3 
{

	public static void main(String[] args) 
	{
		//variables 
		int firstNumber;
		int secondNumber;
		int sum;
		int difference;
		double average;
		
		//create a scanner
		Scanner input = new Scanner(System.in);
		
		
		//prompt the user for second number
		System.out.println("Please enter an integer");
		firstNumber = input.nextInt();
		
		System.out.println("Please enter an another integer");
		secondNumber = input.nextInt();
		
		//calculations 
		sum = firstNumber + secondNumber;
		
		difference = firstNumber - secondNumber;
		
		average = (double) (sum / 2);
		
		System.out.println(firstNumber + " + " + secondNumber + " is " + sum); 
		
		System.out.println(firstNumber + " - " + secondNumber + " is " + difference);
		
		System.out.println("The average of " + firstNumber + " and " + secondNumber + " is " + average);
	}

}
