// import a scanner
import java.util.Scanner;

public class Percentages {


/*
 * Create an application named Percentages whose main() method holds two double variables, 
 * and prompt the user for values. Pass both variables to a method named computePercent() 
 * that displays the two values and the value of the first number as a percentage of the second one. 
 * For example, if the numbers are 2.0 and 5.0, the method should display a statement similar to 2.0 is 40 percent of 5.0. 
 * Then call the method a second time, passing the values in reverse order. Save the application as Percentages.java.
 */

	public static void main(String[] args) 
	{
		Scanner input  = new Scanner(System.in);
		
		//variables
		double firstNum;
		double secondNum;
		
		//users first number
		System.out.println("Enter a decimal number.: ");
		firstNum = input.nextDouble();
		
		//users second number
		System.out.println("Enter another decimal number: ");
		secondNum = input.nextDouble();
		
		computePercent(firstNum, secondNum);
		
		computePercent(secondNum, firstNum);
	}

	private static void computePercent(double firstNum, double secondNum) 
	{
		// TODO Auto-generated method stub
		double percent;
		
		percent = (firstNum / secondNum) * 100;
		
		//display the percent 
		
		System.out.println("You entered " + firstNum + " as the First Decimal Number" + "\n" +
						   "You entered " + secondNum + " as the Second Decimal Number" + "\n" + 
						   firstNum + " is " + percent + " percent of " + secondNum + "\n");
	}


}



