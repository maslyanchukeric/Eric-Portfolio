import java.util.*;
/*
 * The Harrison Group Life Insurance company computes annual policy premiums based on the age the customer
turns in the current calendar year. The premium is computed by taking the decade of the customer’s age,
adding 15 to it, and multiplying by 20. For example, a 34-year-old would pay $360, which is calculated by adding 
the decades (3) to 15 and then multiplying by 20. Write an application that prompts a user for the current year
and a birth year. Pass both to a method that calculates and returns the premium amount, and then display the
returned amount. Save the application as Insurance.java.
 */
public class Insurance {

	public static void main(String[] args) {
		//variables 
		int currentYear;
		int birthYear;
		
		
		Scanner input = new Scanner(System.in);
		
		//ask user for current year 
		System.out.println("Please enter the current year: ");
		currentYear = input.nextInt(); //takes users entry for current year
		
		//ask user for birth year
		System.out.println("Please enter your birth year: ");
		birthYear = input.nextInt();//takes users entry for birth year
		
		
		//calls method to calculate the premium for the customer
		calculatePremium(currentYear, birthYear);
		
	}

	private static void calculatePremium(int currentYear, int birthYear) 
	{ 
		int age;//holds the age of the customer
		int premium; //holds the permium cost
		double premiumPrice; //holds the total premium cost
		
		age = currentYear - birthYear;
		
		premium = age / 10;
		
		premiumPrice = (premium + 15) * 20;
		
		//display the total amount, age, the amount of years customer have been with us 
		System.out.println("Age: " + age);
		System.out.println("Years you have been with us as a customer: " + premium);
		System.out.println("Premium is: " + premiumPrice + " $");
		
	}

}
