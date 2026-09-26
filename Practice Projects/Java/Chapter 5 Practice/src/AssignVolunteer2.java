//import scanner
import java.util.Scanner;
public class AssignVolunteer2 {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		//creating variables
		int donationType;
		String volunteer;
		String message;
		final int CLOTHING_CODE = 1;
		final int OTHER_CODE = 2; 
		final String CLOTHING_PRICE = "Regina";
		final String OTHER_PRICE = "Marco";
		
		//creating a scanner
		Scanner input = new Scanner(System.in);
	
		//prompt the user 
		System.out.println("What type of donation is this");
		System.out.println("Enter " + CLOTHING_CODE + " for clothing, " + OTHER_CODE + " for everything else.");
		donationType = input.nextInt();
		
		//decision for what volunteer is chosen
		if (donationType == CLOTHING_CODE)
		{
			message = "a clothing donation";
			volunteer = CLOTHING_PRICE;
		}	
		else
		{
			message = "a non clothing donation";
			volunteer = OTHER_PRICE;
		}
		
		//output 
		System.out.println("You enter " + donationType);
		System.out.println("The volunteer who will price this item is " + volunteer);
		System.out.println("This is " + message);
	}

}
