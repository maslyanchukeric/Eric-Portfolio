
public class PartyWithConstructor {

	public PartyWithConstructor()
	{
		System.out.println("Creating a Party");
	}
	private int guests;
	
	public int getGueset()
	{
		return guests;
	}
	
	public void setGuest(int numGuests)
	{
		guests = numGuests;
	}
	
	public void displayInvitation()
	{
		System.out.println("Please come to the party");
	}
}

