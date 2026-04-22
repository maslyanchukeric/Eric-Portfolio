import java.util.Scanner;

public class SunShineCase1InClass {

	static Scanner newInput = new Scanner(System.in);	

	//main program
	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		int mins = getRentalTime();
		displayDetails(mins);
		motto();
		

	}

	//method for the motto
	private static void motto() 
	{
		// TODO Auto-generated method stub
		System.out.println("SsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsS\n");
		
		System.out.println("Sunshine Seashore makes it fun in the sun S\n");
		
		System.out.println("SsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsSsS");
	
	}
	
	//method for get rental time
	private static int getRentalTime() 
	{
		// TODO Auto-generated method stub
		System.out.println("Please enter the minutes you need to rent the equipment");
		int rentalMins = newInput.nextInt();
		return rentalMins;
	}
	
	//method for display details
	private static void displayDetails(int totalMins) 
	{
		// TODO Auto-generated method stub
		int mins = totalMins % 60;
		int hour = totalMins / 60;
		double price = (hour * 40.0) + (mins * 1.0);  // Corrected pricing formula
		System.out.println("Rental Price is: $" + price);

	}
}
