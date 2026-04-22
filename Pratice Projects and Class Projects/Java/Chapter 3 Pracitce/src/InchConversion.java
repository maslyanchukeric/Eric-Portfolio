/*
 * There are 12 inches in a foot and 3 feet in a yard. Create a class named InchConversion. Its main() method
	accepts a value in inches from a user at the keyboard and then passes the entered value to two methods.
	One converts the value from inches to feet, and the other converts the same value from inches to yards. Each
	method displays the results with appropriate explanation. Save the application as InchConversion.java.
 */
import java.util.Scanner;

public class InchConversion {

	public static void main(String[] args) {
		
		//variable
		double inches;
		
		//create the scanner
		Scanner input = new Scanner(System.in);
		
		//ask user for the measurement in inches
		System.out.println("Enter a measurement in inches" + "\n");
		inches = input.nextDouble();
		
		//calls method for converting to yards
		convertToYards(inches);
		
		//calls method for converting to feet 
		covertToFeet(inches);

	}

	private static void convertToYards(double inches) {
		double yards;
		
		yards = inches / 36;
		
		System.out.println("Convertion from inches to yard is: " + yards);
		
	}

	private static void covertToFeet(double inches) {
		double feet;
		
		feet = inches / 12;
		
		System.out.println("Convertion from inches to feet is: " + feet);
	}

}
