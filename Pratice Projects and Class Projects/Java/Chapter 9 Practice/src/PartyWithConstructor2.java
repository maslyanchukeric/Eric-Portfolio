
public class PartyWithConstructor2 
{
	public PartyWithConstructor2(int numGuests)
	{
		guests = numGuests;
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


