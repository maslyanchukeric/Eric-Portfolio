//creating the Car subclass
public class Car extends Vehicle 
{
	private int numDoors; //holds the number of doors the car has 
	private boolean isConvertible; //checks if the car is a convertible

	//inherited the vehicle class 
	public Car(int year, String make, String model, double price, int numDoors, boolean isConvertible) 
	{
		super(year, make, model, price); 
	    this.numDoors = numDoors; // Initialize numDoors
	    this.isConvertible = isConvertible; // Initialize isConvertible
	}

	//get the number of doors
	public int getNumDoors() 
	{
		//returns the amount of doors on car 
		 return numDoors;
	}
	
	//get the if the car is convertible
	public boolean getIsConvertible()
	{
		return isConvertible;
	}
	
	//set the number of doors 
	public void setNumDoors(int numDoors)
	{
		this.numDoors = numDoors;
	}
	
	//set if the car is convertible
	public void setConvertibel(boolean isConvertible)
	{
		this.isConvertible = isConvertible;
	}
	
	//Method to display the car details
	public void displayCarDetails()
	{
		//display the vehicle details 
		super.displayVehicleDetails();
		
		//display the following 
		System.out.println("Number of doors on car: " + numDoors);
		
		//decision if the car is a convertible
		if(isConvertible)
		{
			System.out.println("Convertible: YES");
		}
		else
		{
			System.out.println("Convertible: NO");
		}
	}
}
