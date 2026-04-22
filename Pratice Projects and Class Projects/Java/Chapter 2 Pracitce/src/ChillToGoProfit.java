import java.util.Scanner;

public class ChillToGoProfit {

	public static void main(String[] args) {
		
		/*
		 * Huntington boys and girls club is selling chill to go dinners.
		 * Cost to make a adult meal is 4.35 and a kids meal is 3.10
		 * write a program that to display the total profit for each meal as well as
		 * the grand total profit.
		 */
		
		//varibles
		int adultMeals;
		int kidsMeals;
		double adultMealCost = 7;
		double kidsMealCost = 4;
		double adultMealTotal = 0;
		double kidsMealTotal = 0;
		double totalPrice = 0;
		double adultMealMake = 4.35;
		double kidsMealMake = 3.10;
		double profitAdultMeal = 0;
		double profitKidMeal = 0;
		double totalProfit = 0;
		
		Scanner input = new Scanner(System.in); //users input from the key board
		
		System.out.println("Please enter the amout of Adults meals you would like to order"); //user enters amount of adults meals they order
		adultMeals = input.nextInt();
		
		System.out.println("Please enter the amout of Kids meals you would like to order"); //user enters amount of kid meals they order
		kidsMeals = input.nextInt();
		
		adultMealTotal = adultMeals * adultMealCost; // 7 * users entry
		
		kidsMealTotal = kidsMeals * kidsMealCost; // 4 * user entry
		
		totalPrice = adultMealTotal + kidsMealTotal; // (7 * adultMeals) + (4 * kidMeals)
		
		profitAdultMeal = adultMeals * (adultMealCost - adultMealMake); // whatever user enters ( (adultMeals) * (7 - 4.35))
		
		profitKidMeal = kidsMeals * (kidsMealCost - kidsMealMake); // whatever user enters ( (kidsMeals) * (4 - 3.10))
	
		totalProfit = (adultMeals * (adultMealCost - adultMealMake)) + (kidsMeals * (kidsMealCost - kidsMealMake)); //whatever user enters ( (adultMeals) * (7 - 4.35)) + whatever user enters ( (kidsMeals) * (4 - 3.10)) 
		
		//display the cost for user
		System.out.println("Adult Meals Ordered: " + adultMeals + "\n"+ 
						   "Kids Meals Ordered: " + kidsMeals + "\n" +
						   "Adult Meal Cost: " + adultMealCost + "\n" +
						   "Kids Meal Cost: " + kidsMealCost + "\n" +
						   "Total Adult Meal Cost: " + adultMealTotal + "\n" +
						   "Total Kids Meal Cost: " + kidsMealTotal + "\n" + 
						   "Total Price: " + totalPrice ) ;
		
		System.out.println(); //blank space
		
		//profit display
		System.out.println("Adult Meal Profit = " + profitAdultMeal + "\n" + 
						   "Kids Meal Profit =  " + profitKidMeal + "\n" + 
				           "Total Profit = " + totalProfit);
	}

}
