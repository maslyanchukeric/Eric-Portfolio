import java.util.*;
public class ChillToGo {

	public static void main(String[] args) 
	{
		/*
		 * Huntington boys and girls club is selling chill to go dinners.
		 * Price for the dinners is 7$ for an adult and 4$ for a child
		 * write a program that accepts the number of each type of meal ordered and diplay total money collected for adults meals, kids meals,
		 * and all meals 
		 */
		
		//variable
		int adultMeals;
		int kidsMeals;
		int adultMealCost = 7;
		int kidsMealCost = 4;
		int adultMealTotal = 0;
		int kidsMealTotal = 0;
		int totalPrice = 0;
		
		Scanner input = new Scanner(System.in); //users input from the key board
		
		System.out.println("Please enter the amout of Adults meals you would like to order"); //user enters amount of adult meals they want
		adultMeals = input.nextInt();
		
		System.out.println("Please enter the amout of Kids meals you would like to order"); //user enter amount of kid meals they want
		kidsMeals = input.nextInt();
		
		adultMealTotal = adultMeals * adultMealCost; // 7 * user entry
		
		kidsMealTotal = kidsMeals * kidsMealCost; // 4 * user entry
		
		totalPrice = adultMealTotal + kidsMealTotal; // (7 * user entry) + (4 * user entry)
		
		//diplay user cost
		System.out.println("Adult Meals Ordered: " + adultMeals + "\n"+ 
						   "Kids Meals Ordered: " + kidsMeals + "\n" +
						   "Adult Meal Cost: " + adultMealCost + "\n" +
						   "Kids Meal Cost: " + kidsMealCost + "\n" +
						   "Total Adult Meal Cost: " + adultMealTotal + "\n" +
						   "Total Kids Meal Cost: " + kidsMealTotal + "\n" + 
						   "Total Price: " + totalPrice ) ;
	}

}
