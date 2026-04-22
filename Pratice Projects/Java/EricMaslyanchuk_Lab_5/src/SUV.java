//creating the SUV subclass
public class SUV extends Vehicle 
{ 	
	int seatCapacity; // Holds the number of seats in the SUV
	boolean isthirdRow; // Checks if the SUV has a third row of seating

	// Constructor for the SUV class
	public SUV(int year, String make, String model, double price, int seatCapacity, boolean isthirdRow) 
	{
		super(year, make, model, price);
        this.seatCapacity = seatCapacity;
        this.isthirdRow = isthirdRow;
    }

    // Get for seat capacity
    public int getSeatCapacity() 
    {
        return seatCapacity; // Returns the seat capacity
    }

    // Get for third row
    public boolean thirdRow() 
    {
        return isthirdRow; // Returns whether the SUV has a third row
    }

    // Set for seat capacity
    public void setSeatCapacity(int seatCapacity) 
    {
        this.seatCapacity = seatCapacity; // Sets the seat capacity
    }

    // Set for third row
    public void setThirdRow(boolean thirdRow) 
    {
        this.isthirdRow = isthirdRow; // Sets whether the SUV has a third row
    }

    // Method to display SUV-specific details
    public void displaySUVDetails() 
    {
    	super.displayVehicleDetails();// Calls the parent class to display common vehicle details

        // Displays the SUV-specific details
        System.out.println("SUV Seats: " + seatCapacity);

        // Decision for whether the SUV has a third row
        if (isthirdRow) 
        {
            System.out.println("Third Row: YES");
        } else {
            System.out.println("Third Row: NO");
        }
    }
}