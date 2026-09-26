import java.util.*;
public class CustomerSurvey {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		//Variables
		int rating;
		final int MIN = 1;
		final int MAX = 5;
		
		//creating scanner
		Scanner input = new Scanner(System.in);
		
		//explaining to user what to do 
		System.out.println("Please enter a value");
		System.out.println("represents your satisfaction with");
		System.out.println("our service.");
		System.out.println("Enter value between " + MIN);
		System.out.println("and " + MAX);
		System.out.println("with " + MAX + " meaning highly");
		System.out.println("satisfied and");
		System.out.println(MIN + " meaning not at all satisfied.");
		System.out.println("Enter your rating");
		
		//getting the users rating 
		rating = input.nextInt();
		
		//creating a loop to execute while users response is out of range
		while(rating < MIN || rating > MAX) 
		{
			System.out.println("You must enter a value!");
			System.out.println("Between " + MIN + " and " + MAX);
			System.out.println("Please try again >> ");
			System.out.println("Enter your rating");
			rating = input.nextInt();
		}
		
		System.out.println("Thank you");
	}

}
