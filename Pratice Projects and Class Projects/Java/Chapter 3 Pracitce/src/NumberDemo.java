import java.util.Scanner;
public class NumberDemo {

	public static void main(String[] args) {
		/*
		 * Create a program whose main method holds 2 integer variables. 
		 * Prompte the user for the integers.
		 * pass the intergers into a method named displayTwiceTheNumber(), displayNumberPlusFive() and, displayNumberSquared
		 * 
		 */
		
		//ask the user for the 2 numnbers 
		int x;
		int y;
		
		//create a scanner
		Scanner input = new Scanner(System.in);
		
		System.out.println("Please enter you 1st Number: ");
		x = input.nextInt();
		
		System.out.println("Please enter you 2nd Number:");
		y = input.nextInt();
		
		
		displayTwiceTheNumber(x,y);
		
		displayNumberPlusFive(x,y);
		
		displayNumberSquared(x,y);
	}

	private static void displayNumberSquared(int x, int y) {
		int squaredx;
		int squaredy;
		
		//calculation
		squaredx = x * x;
		squaredy = y * y;
		
		//display the sqaurd x and y
		System.out.println("Squared Interge (1): " + squaredx);
		System.out.println("Squared Interge (2): " + squaredy);
		System.out.println();
		
	}

	private static void displayNumberPlusFive(int x, int y) {
		int addFive1;
		int addFive2;
		
		//calculation
		addFive1 = x + 5;
		addFive2 = y + 5;
		
		//display the sqaurd x and y
		System.out.println("Integer + 5 (1): " + addFive1);
		System.out.println("Integer + 5 (2): " + addFive2);
		System.out.println();
		
		
	}

	private static void displayTwiceTheNumber(int x, int y) {
		int twice1;
		int twice2;
		
		//calculation
		twice1 = x * 2;
		twice2 = y * 2;
		
		//display the sqaurd x and y
		System.out.println("Integer Twice the Number (1): " + twice1);
		System.out.println("Integer Twice the Number (2): " + twice2);
		System.out.println();
		
	}

}
