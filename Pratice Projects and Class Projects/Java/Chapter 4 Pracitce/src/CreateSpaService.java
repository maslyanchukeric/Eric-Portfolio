import java.util.Scanner;

public class CreateSpaService 
{
	public static void main(String[] args)
	{
		//creating the objects from the SpaService class
		SpaService firstService = new SpaService();
		SpaService secondService = new SpaService();
		
		// calling getData() method to fill the objects with data
		firstService = getData(firstService);
		//secondService = getData(secondService);
		
		//adding a 3rd service with 2 parameter constructor
		SpaService thridService = new SpaService("Facial", 22.99);
		
		//display the users first service
		System.out.print("\n");
		System.out.println("First Service Details");
		System.out.println("First Service is :" + firstService.getServiceDescrtiption()); //gets the first service from the SpaService Class
		System.out.println("Price is: " + firstService.getPrice() + "\n"); //gets the first service price from the SpaService Class
		
		//display the users second service
		System.out.println("Second Service Details");
		System.out.println("Second Service is :" + secondService.getServiceDescrtiption()); //gets the second service from the SpaService Class
		System.out.println("Price is: " + secondService.getPrice() + "\n"); //gets the second service price from the SpaService Class
		
		//display the 3rd service
		System.out.print("\n");
		System.out.println("Third Service Details");
		System.out.println("Third Service is : " + thridService.getServiceDescrtiption()); //gets the first service from the SpaService Class
		System.out.println("Price is: " + thridService.getPrice() + "\n"); //gets the first service price from the SpaService Class
		
	}
	
	 // The getData method that accepts and returns a SpaService object
    public static SpaService getData(SpaService service)
    {
        // variables 
        String serviceDescription; // holds the service description that the user enters
        double price; // holds the price that the user enters
        
        // creating the scanner
        Scanner keyboard = new Scanner(System.in);
        
        // prompting the user to enter the service and price
        System.out.print("Enter service >> ");
        serviceDescription = keyboard.nextLine();
        
        System.out.print("Enter price >> ");
        price = keyboard.nextDouble();
        
        // clearing the input buffer
        keyboard.nextLine();
        
        // setting the service description and price for the SpaService object
        service.setServiceDescription(serviceDescription);
        service.setPrice(price);
        
        // returning the filled SpaService object
        return service;
    }
	
}
