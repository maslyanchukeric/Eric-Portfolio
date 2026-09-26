import java.util.Scanner;

public class IntegerDemoInteractive 
{
	public static void main(String [] agrs)
	{
		//variable 
		String name; 
	
		//creating a scanner
		Scanner input = new Scanner(System.in);
			
		// Input for integer
		System.out.print("Please enter an integer >> ");
		int anInt = input.nextInt();
			
		// Input for byte
		System.out.print("Please enter an byte >> ");
		byte aByte= input.nextByte();
		
		// Input for short
		System.out.print("Please enter an short >> ");
		short aShort = input.nextShort();
		
		// Input for long
		System.out.print("Please enter an long >> ");
		long aLong = input.nextLong();
		
		// Consume the leftover newline character
        input.nextLine();
		
        //Input for name 
		System.out.println("Please enter your name >>");
		name = input.nextLine();
		
		//output 
		System.out.println("Thank you, " + name + "!");
		
		
		//output 
		System.out.println("The int is " + anInt);
		System.out.println("The byte is " + aByte);
		System.out.println("The short is " + aShort);
		System.out.println("The long is " + aLong);		
	}		
}
