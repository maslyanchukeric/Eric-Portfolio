//import scanner
import java.util.Scanner;
public class AssignVolunteer4 {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		
		//creating variables
		int donationType;
		String volunteer;
		String message;
		
		//constant variables
		final int CLOTHING_CODE = 1;
		final int FURNITURE_CODE = 2; 
		final int ELECTRONIC_CODE = 3;
		final int OTHER_CODE = 4;
		final String CLOTHING_PRICER = "Regina";
		final String OTHER_PRICER = "Marco";
		final String FURNITURE_PRICER = "Wei";
		final String ELECTRONIC_PRICER = "Lydia";
		
		
		//creating a scanner
		Scanner input = new Scanner(System.in);
	
		//prompt the user 
		System.out.println("What type of donation is this");
		System.out.println("Please enter a integer. 1-4");
		donationType = input.nextInt();
		
		//decision for what volunteer is chosen
		switch(donationType)
		{
			case(CLOTHING_CODE):
			{
			volunteer = CLOTHING_PRICER;
			message =  "a clothing donation";
			break;
			}
			case (FURNITURE_CODE):
			{
			volunteer = FURNITURE_PRICER;
			message =  "a furniture donation";
			break;
			}
			case (ELECTRONIC_CODE):
			{
			volunteer = ELECTRONIC_PRICER;
			message =  "a electronic donation";
			break;
			}
			case (OTHER_CODE):
			{
			volunteer = OTHER_PRICER;
			message =  "another donation type";
			break;
			}
			default:
			{
			volunteer = "invalid";
			message = "an invalid donation type";
			}
		}
		 
		//output 
		System.out.println("You enter " + donationType);
		System.out.println("The volunteer who will price this item is " + volunteer);
		System.out.println("This is " + message);
		
	}

}
