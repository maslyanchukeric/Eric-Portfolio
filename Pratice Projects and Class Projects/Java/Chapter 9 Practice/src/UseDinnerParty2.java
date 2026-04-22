import java.util.Scanner;

public class UseDinnerParty2 
{
	public static void main(String[] args) 
	{
		int guests; //hold the guests
		int choice; //hold dinner choice
		Party aParty = new Party(); //new party object is created
		DinnerParty aDinnerParty = new DinnerParty();
		Scanner keyBoard = new Scanner(System.in); //scanner is created
		
		
		System.out.println("Enter number of guests for the party"); //user is asked to enter num of guests
		guests = keyBoard.nextInt(); // scanner take the users entry
		aParty.setGuest(guests); //guests are set 
		System.out.println("The party has " + aParty.getGueset() + " guests"); //display the guests 
		
		aParty.displayInvitation(); //displays the invitation
		
		System.out.println("Enter number of guest for dinner party"); //user is asked to enter num of guests
		guests = keyBoard.nextInt(); // scanner take the users entry
		aDinnerParty.setGuest(guests); //guests are set 
		
		System.out.println("Enter the menus option -- 1 for chicken or 2 for beef"); //user is asked to choice one
		choice = keyBoard.nextInt(); //scanner takes the user entry
		aDinnerParty.setDinnerChoice(choice); //choice is set
		System.out.println("The dinner has " + aDinnerParty.getGueset() + " guests"); //displays the guests
		System.out.println("Menu option " + aDinnerParty.getDinnerChoice() + " will be served"); //displays the choice

		aDinnerParty.displayInvitation(); //diplays the invitaion
		
	}
}
