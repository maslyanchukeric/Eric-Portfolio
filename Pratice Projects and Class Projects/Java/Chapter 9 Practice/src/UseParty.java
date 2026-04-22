import java.util.Scanner;

public class UseParty {

	public static void main(String[] args) 
	{
		int guests; //hold the guests 
		Party aParty = new Party(); //new party object is created
		Scanner keyBoard = new Scanner(System.in); //scanner is created
		
		
		System.out.println("Enter number of guests for the party"); //user is asked to enter num of guests
		guests = keyBoard.nextInt(); // scanner take the users entry
		aParty.setGuest(guests); //guests are set 
		System.out.println("The party has " + aParty.getGueset() + " guests"); //display the guests 
		
		aParty.displayInvitation(); //displays the invitation
	}
}
