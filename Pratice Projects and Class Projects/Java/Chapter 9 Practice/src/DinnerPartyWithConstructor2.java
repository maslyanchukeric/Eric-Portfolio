
public class DinnerPartyWithConstructor2 extends PartyWithConstructor2 
{
	public DinnerPartyWithConstructor2(int numGuests)
	{
		super(numGuests);
	}
	
    private int dinnerChoice;

    public void setDinnerChoice(int choice) {
        dinnerChoice = choice;
    }

    public int getDinnerChoice() {
        return dinnerChoice;
    }
}

