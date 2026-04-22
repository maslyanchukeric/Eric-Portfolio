//creating a class for different vehicle
public class Vehicle 
{
	//creating the field for the class
	private String make; //holds the make of the vehicle
	private String model; //holds the model of the vehicle
	private int year; //holds the year of the vehicle
	private double price; //hold the price of the vehicle

	//constructor
	public Vehicle (int year, String make, String model, double price )
	{
		this.year = year;
		this.make = make;
		this.model = model;
		this.price = price;
		
	}
	
	//gets the vehicle year 
	public int getYear()
	{
		//returns the year of vehicle
		return year;
	}
	
	//gets the vehicle make
	public String getMake()
	{
		//returns the make of vehicle
		return make;
	}
	
	//gets the vehicle model
	public String getModel()
	{
		//returns the model of vehicle
		return model;
	}
	
	//gets the vehicle price
	public double getPrice()
	{
		//returns the price of vehicle
		return price;
	}
	
	//sets the vehicle year
	public void setYear(int year)
	{
		 if (year > 1885)
		 {
			 // The first car was invented in 1885
		     this.year = year;
		  } 
		 else 
		 {
			 System.out.println("Invalid year! Must be after 1885.");
		 }
	}
	
	//sets the vehicle make
	public void setMake(String make)
	{
		//sets make in the class
		this.make = make;
	}
	
	//sets the vehicle model;
	public void setModel(String model)
	{
		//sets model in the class
		this.model = model;
	}
	
	//sets the vehicle price
	public void setPrice (double price)
	{
		 if (price >= 0) 
		 {
			 this.price = price;
	     } 
		 else 
		 {
			 System.out.println("Invalid price! Price cannot be negative.");
	     }
	}
	
	//display the vehicle info
	public void displayVehicleDetails() 
	{
	    System.out.println("Vehicle Year: " + year);
	    System.out.println("Vehicle Make: " + make);
	    System.out.println("Vehicle Model: " + model);
	    System.out.println("Vehicle Price: $" + price);
	    System.out.println("\n");
	}	
}
