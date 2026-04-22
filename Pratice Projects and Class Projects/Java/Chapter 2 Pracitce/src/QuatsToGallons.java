//imported a java scanner 
import java.util.Scanner;
public class QuatsToGallons 
{

	public static void main(String[] args) 
	{
		//variables 
		final int quarts = 4;
		int quartsLeft;
		int quartsNeeded;
		int gallons;
		
		//create a scanner 
		Scanner inputDevice = new Scanner(System.in);
		
		//prompt the user and ask who many quarts do you need 
		System.out.println("How many quarts do you need?");
		quartsNeeded = inputDevice.nextInt();
		
		//calculations
		
		//getting from quarts to gallons 
		gallons = quartsNeeded / quarts;
		
		quartsLeft = quarts % gallons;
		
		
		System.out.println("A job that needs "+ quartsNeeded + " quarts requires " + gallons + " gallons, plus " + quartsLeft + " quarts as well.");
			
	}

}
