import java.util.Scanner;

public class YummyCase1InClass 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		//ask the user for input how many guests are attending?
		motto();
		int numGuests = getnumGuests();
		eventInfo(numGuests);
	}

	
	

	private static void motto() 
	{
		// TODO Auto-generated method stub
		System.out.println("********************************************");
		System.out.println("*Yummy makes the food that makes it a party*");
		System.out.println("********************************************");
	}
	private static int getnumGuests() 
	{
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		System.out.println("How many guests are attending your event: ");
		
		return input.nextInt();
	}
	private static void eventInfo(int numGuests)
	{
		// TODO Auto-generated method stub
		double price = numGuests * 35.0;
		System.out.println("The price of this event is: $ " + price);
		if(numGuests > 50)
		{
			System.out.println("This is a a large event!");
		}
		else
		{
			System.out.println("This is a a small event!");
		}
		
		
	}

}
