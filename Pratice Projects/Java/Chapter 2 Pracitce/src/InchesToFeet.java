import java.util.Scanner;
public class InchesToFeet {

	public static void main(String[] args) {
		
		//variabels 
		final int inches_per_foot = 12; //constant 12 inches per foot
		int feet; //holds the feet number 
		
		Scanner input = new Scanner(System.in); //created a scanner
		
		System.out.println("Enter amount of inches"); //asked the user to enter a number of inches
		int inches = input.nextInt(); //users input by keyboard
		
		feet = inches / inches_per_foot; //calculation inches to feet
		
		int inchesRemaining = inches_per_foot % feet; //get the remainder of feet and inches
		
		System.out.println("Feet: " + feet + " inches: " + inchesRemaining); //displays the feet and inches

	}

}
