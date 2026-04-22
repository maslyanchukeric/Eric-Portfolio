//creating the truck subclass
public class Truck extends Vehicle 
{
	private double bedLength; //holds the truck bed size
	private double towingCapacity; //holds the truck towing capacity

	//inherited the vehicle class
	public Truck(int year, String make, String model, double price, double bedLength, double towingCapacity) 
	{
		super(year, make, model, price);
		this.bedLength = bedLength; // Initialize bedLength
	    this.towingCapacity = towingCapacity; // Initialize towingCapacity
	}
	
	//get the truck bed length
	public double getBedLength()
	{
		//return the bed length
		return bedLength;
	}
	
	//get the truck tow capacity
	public double getTowingCapacity()
	{
		//return the towingCapacity
		return towingCapacity;
	}

	//set the truck bed length
	public void setBedLength(double bedLength)
	{
		this.bedLength = bedLength;
	}
	
	//set the truck bed length
	public void setTowingCapacity(double towingCapacity)
	{
	    this.towingCapacity = towingCapacity; 
	}
	
	//method to display truck details
	public void displayTruckDetails() 
	{
		//display the vehicle details 
		super.displayVehicleDetails();
		
		//display the following
		System.out.println("Truck Bed Length: " + bedLength);
		System.out.println("Truck Towing Capacity: " + towingCapacity);
	}
}
