import java.util.*;
public class MinutesConvertion {

	public static void main(String[] args) {
		/*
		 * Write a programthat accepts an integer number of minutes from a user and converts it both to hours and days.
		 */
		
		int mins;
		int hours;
		double days;

		Scanner input = new Scanner(System.in);
		
		System.out.println("Enter number of mins: ");
		mins = input.nextInt();
		
		hours = mins / 60;
		
		days = hours / 24;
		
		System.out.println("Mins entered: " + mins + "\n" +
				           "Hours: " + hours + "\n" +
				           "Days: " + days);
	}

}
