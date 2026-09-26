import java.util.Scanner;

public class QuartsToGallonsInteractive {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// variables
		int quarts;
		int quartsLeft;
		int gallons;

		// create a scanner
		Scanner inputDevice = new Scanner(System.in);

		// prompt the user and ask who many quarts do you need
		System.out.println("How many quarts do you need?");
		 quarts = inputDevice.nextInt();

		// calculations

		// getting from quarts to gallons
		gallons = quarts / 4;

		//calculation on how many quarts left
		quartsLeft = gallons % 4;

		System.out.println("Gallons needed: " + gallons + " Quarts needed: " + quartsLeft);
	}

}
