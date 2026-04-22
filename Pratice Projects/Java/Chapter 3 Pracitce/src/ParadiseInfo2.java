//import a scanner
import java.util.Scanner;

public class ParadiseInfo2
{

	public static void main(String[] args) 
	{
		//adding variables
		double price;
		double discount;
		double savings;
		Scanner keyboard = new Scanner(System.in);
		
		//method is called in the main
		displayInfo();
		
		//prompt user for min discount and price
		System.out.println("Enter a cutoff for discount");
		price = keyboard.nextDouble();
		
		//prompt user for discount rate
		System.out.println("Enter discount rate as a whole number.");
		discount = keyboard.nextDouble();
		
		//calculation for saving
		savings = computeDiscountInfo(price, discount);
		
		//display the saving info
		System.out.println("Special this week on any service over $: " + price );
		System.out.println("Discount of " + discount + "% percent");
		System.out.println("That's a saving of at least $: " + savings );
		

	}
	
	//creating a method for displayInfo()
	public static void displayInfo()
	{
		System.out.println("Paradise Day Spa wants to pamper you.");
		System.out.println("We will make you look good.");
	}
	
	//creating the method for computeDiscountInfo
	public static double computeDiscountInfo(double price, double discountRate)
	{
		double savings;
		savings = price * discountRate / 100;
		return savings;
	}

}
