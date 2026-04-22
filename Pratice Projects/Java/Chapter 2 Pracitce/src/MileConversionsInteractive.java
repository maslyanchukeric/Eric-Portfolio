import java.util.Scanner;

public class MileConversionsInteractive {

	public static void main(String[] args) {
		// variable constants of how many miles are in inchs, feet, yards
		final int inches_per_mile = 63360;
		final int feet_per_mile = 5280;
		final int yards_per_mile = 1760;

		// variable for miles is entered by user
		// create the scanner
		Scanner input = new Scanner(System.in);

		System.out.println("Enter amount of miles");
		double miles = input.nextDouble();

		// calculations
		double inches = miles * inches_per_mile;
		double feet = miles * feet_per_mile;
		double yards = miles * yards_per_mile;

		// Display results with explanatory text
		System.out.println(miles + " mile(s) is equivalent to:");
		System.out.println(inches + " inches");
		System.out.println(feet + " feet");
		System.out.println(yards + " yards");
	}

}
