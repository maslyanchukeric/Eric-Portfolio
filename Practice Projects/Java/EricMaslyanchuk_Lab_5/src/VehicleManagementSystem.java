//creating the main program

//import scanner 
import java.util.Scanner;
//main program 
public class VehicleManagementSystem 
{
	//creating a array of vehicles
	private static Vehicle[] vehicles = new Vehicle[10];
	private static int vehicleCount = 0; //holds the count of vehicles 
	private static int totalVehicles = 10;
	
	//variables to hold year, make, model, price, numDoors, isConvertible, bedLength, towingCapacity, seatCapacity, thirdRow
	private int year;
	private String make;
	private String model;
	private double price;
	private int numDoors;
	private boolean isConvertible;
	private double bedLength;
	private double towingCapacity;
	private int seatCapacity;
	private boolean thirdRow;
	private String hullType; 
	private String engineType; 
	private static int userChoice;
	private static String exiting = "No";
	
	//create scanner object
	static Scanner input = new Scanner(System.in);

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
	
			while(exiting.equalsIgnoreCase("No"))
			{
				System.out.println("\n");
				System.out.println("Welcome to Vehicle Management System");
				System.out.println("**********************************************");
				System.out.println("Choose an Option!");
				System.out.println("1. Add a Car");
				System.out.println("2. Add a Truck");
				System.out.println("3. Add a SUV");
				System.out.println("4. Add a Boat");
				System.out.println("5. Display All Vehicle Info");
				System.out.println("6. Exit");
				System.out.println("**********************************************");
				System.out.println("Vehicle count : " + vehicleCount );
			
				userChoice = input.nextInt(); //holds user choice
					input.nextLine();
				switch(userChoice)
				{
					case 1:
					{
						addCar(); //method addCar is called
						break;
						
					}
					case 2:
					{
						addTruck(); //method addTruck is called
						break;
					}
					case 3: 
					{
						addSUV(); //method addSUV is called
						break;
					}
					case 4:
					{
						addBoat();
						break;
					}
					case 5: 
					{
						//displays all vehicle info
						displayAllVehicleInfo();
						break;
					}
					case 6:
					{
						System.out.println("Exiting Vehicle Management System! Are you sure you want to exit? Yes or No");
						exiting = input.nextLine();
						break;
					}
				}
			}
			
			//Thank you message
			System.out.println("Thank for using the Vehicle Management System");
			
		}
		
	//method add the car to array
	private static void addCar()
	{
		//decision if the array is full
		if (vehicleCount >= vehicles.length) 
		{
			//error popes up when there are more then 10 vehicles in array
	        System.out.println("Vehicles Array is full! Cannot add more vehicles.");
	        return;
	    }
		
		//Ask user for details of the car
		//year
		System.out.print("Enter Car Year: ");
	    int year = input.nextInt();
	    input.nextLine();

	    //make
	    System.out.print("Enter Car Make: ");
	    String make = input.nextLine();   

	    //model
	    System.out.print("Enter Car Model: "); 
	    String model = input.nextLine();  

	    //doors
	    System.out.print("Enter Number of Doors: ");
	    int numDoors = input.nextInt();
	    input.nextLine();

	    //isCovertible
	    System.out.print("Enter if Car is Convertible (Yes/No): ");
	    String convertibleInput = input.nextLine();
	    boolean isConvertible = convertibleInput.equalsIgnoreCase("Yes");

	    //price
	    System.out.print("Enter Car Price: ");
	    double price = input.nextDouble();
	    input.nextLine();
		
		// Store the car in the array
	    vehicles[vehicleCount] = new Car(year, make, model, price, numDoors, isConvertible);

		//what should we do when vehicle is added
		vehicleCount ++;
		
		//tell the user that car was added
		System.out.println("Car was added Successfully!");
	}
	
	//method for adding truck
	private static void addTruck()
	{
		//error popes up when there are more then 10 vehicles in array
		if (vehicleCount >= vehicles.length) 
		{
	        System.out.println("Vehicles Array is full! Cannot add more vehicles.");
	        return;
	    }
		
		//Ask user for details of the truck
		
		//year
		 System.out.print("Enter Truck Year: ");
		 int year = input.nextInt();
		 input.nextLine();
		 
		 //make
		 System.out.print("Enter Truck Make: ");
		 String make = input.nextLine();

		 //model
		 System.out.print("Enter Truck Model: "); 
		 String model = input.nextLine(); 
		 
		 //bed length
		 System.out.print("Enter Truck Bed Length: ");
		 double bedLength = input.nextDouble();
		 input.nextLine();
		  
		 //tow capacity
		 System.out.print("Enter Truck Towing Capacity: ");
		 double towingCapacity = input.nextDouble();
		 input.nextLine();

		 //price
		 System.out.print("Enter Truck Price: ");
		 double price = input.nextDouble();
		 input.nextLine();
		
		// Store the car in the array
	    vehicles[vehicleCount] = new Truck(year, make, model, price, bedLength, towingCapacity);
	   
		//what should we do when vehicle is added
		vehicleCount ++;
		
		//tell the user that car was added
		System.out.println("Truck was added Successfully!");
	
	}
	
	//method for adding SUV
	private static void addSUV()
	{
		//error popes up when there are more then 10 vehicles in array
		if (vehicleCount >= vehicles.length) 
		{
	        System.out.println("Vehicles Array is full! Cannot add more vehicles.");
	        return;
	    }
		
		//Ask user for details of the SUV
		
		//year
		System.out.print("Enter SUV Year: ");
	    int year = input.nextInt();
	    input.nextLine();

	    //make
	    System.out.print("Enter SUV Make: ");
	    String make = input.nextLine();

	    //model
	    System.out.print("Enter SUV Model: "); 
	    String model = input.nextLine();

	    //seat capacity
	    System.out.print("Enter SUV Seat Capacity: ");
	    int seatCapacity = input.nextInt();
	    input.nextLine();

	    //isthirdRow
	    System.out.print("Enter if SUV has Third Row (Yes/No): ");
	    String isthirdRowInput = input.nextLine();
	    boolean isThirdRow = isthirdRowInput.equalsIgnoreCase("Yes");

	    //price
	    System.out.print("Enter SUV Price: ");
	    double price = input.nextDouble();
	    input.nextLine();
				
		// Store the car in the array
		vehicles[vehicleCount] = new SUV(year, make, model, price, seatCapacity, isThirdRow );
		
		//what should we do when vehicle is added
		vehicleCount ++;
				
		//tell the user that car was added
		System.out.println("SUV was added Successfully!");
	}
	
	//method to add a boat
	private static void addBoat()
	{
		//error popes up when there are more then 10 vehicles in array
		if (vehicleCount >= vehicles.length) 
		{
	        System.out.println("Vehicles Array is full! Cannot add more vehicles.");
	        return;
	    }
		
		//user is asked to enter boat info
		 System.out.print("Enter Boat Year: ");
		 int year = input.nextInt();
		 input.nextLine();

		 //make
		 System.out.print("Enter Boat Make: ");
		 String make = input.nextLine();
		 
		 //model
		 System.out.print("Enter Boat Model: "); 
		 String model = input.nextLine();

		 //hull type
		 System.out.print("Enter Boat Hull Type: ");
		 String hullType = input.nextLine();

		 //engine type
		 System.out.print("Enter Boat Engine Type: ");
		 String engineType = input.nextLine();

		 //price
		 System.out.print("Enter Boat Price: ");
		 double price = input.nextDouble();
		 input.nextLine();
		 
		 
		// Store the car in the array
		vehicles[vehicleCount] = new Boat(year, make, model, price, hullType, engineType );
			  
		//what should we do when vehicle is added
		vehicleCount ++;
				
		//tell the user that car was added
		System.out.println("Boat was added Successfully!");
		
	}
	
	//method to display all vehicle info 
	private static void displayAllVehicleInfo()
	{
		System.out.println("Showing the Vehicles");
		if(vehicleCount == 0) 
		{
		    System.out.println("No vehicles available.");
		    return;
		}
		
		//loop that loops thru the vehicle array 
		for(int i = 0 ; i < vehicles.length; i++)
		{
			if(vehicles[i] != null) //checks if vehicle[i] are empty
			{
				vehicles[i].displayVehicleDetails(); //display vehicle details from vehicle class
			}
		}
	}
}
