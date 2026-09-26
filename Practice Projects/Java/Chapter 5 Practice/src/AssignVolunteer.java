//import scanner
import java.util.Scanner;
public class AssignVolunteer {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		//creating variables
		int donationType;
		String volunteer;
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
			volunteer = CLOTHING_PRICE;
		}
		else
		{
			volunteer = OTHER_PRICE;
		}
		
		//output 
		System.out.println("You enter " + donationType);
		System.out.println("The volunteer who will price this item is " + volunteer);
	}

}
