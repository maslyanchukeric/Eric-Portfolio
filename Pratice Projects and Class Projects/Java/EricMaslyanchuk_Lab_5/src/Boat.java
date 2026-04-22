//creating the boat class
public class Boat extends Vehicle
{

	private String hullType; //Holds hull type like (fibergrass or Aluminium)
	private String engineType; //Holds engine type like (inboard or outboard)
	
	//inherited the vehicle class 
		public Boat(int year, String make, String model, double price, String hullType, String engineType) 
		{
			super(year, make, model, price);
		    this.hullType = hullType; // Initialize hullType
		    this.engineType = engineType; // Initialize engineType
		    
		}
		
		//gets the boat hull type 
		public String getHullType()
		{
			//returns the boat hull type
			return hullType;
		}
		
		//gets the boat engine
		public String getEngineType()
		{
			//returns the boat engine type
			return engineType;
		}
		
		//set boat hull type
		public void setHullType(String hullType)
		{
			this.hullType = hullType;
		}
		
		//sets boat engine type
		public void setEngineType(String engineType)
		{
			this.engineType = engineType;
		}
		
		//method to display boat details
		public void displayBoatDetails() 
		{
			//display the vehicle details 
			super.displayVehicleDetails();
			
			//display the following
			System.out.println("Boat Hull Type: " + hullType);
			System.out.println("Boat Engine Type: " + engineType);
		}
}
