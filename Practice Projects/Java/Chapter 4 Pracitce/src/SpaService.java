//Creating Instance Methods in a class
public class SpaService //Class name
{
	//field declarations
	private String serviceDescription;
	private double price;
	
	//Constructor
	/* sets the serviceDescription to XXX and price to 0*/
	//public SpaService()
	//{
		//serviceDescription = "XXX";	
		//price = 0;
	//}
	
	  // Default Constructor
    /* Sets the serviceDescription to "XXX" and price to 0 */
    public SpaService() 
    {
        this("XXX", 0); // Calls the overloaded constructor using `this`
    }
	
	//Overloaded Constructor
	public SpaService(String desc, double pr)
	{
		serviceDescription = desc;
		price = pr;
	}
	
	//Method to set the ServiceDescription 
	public void setServiceDescription(String service)
	{
		serviceDescription = service;
	}
	
	//Method to set the price
	public void setPrice (double servicePrice) 
	{
		price = servicePrice;
	}
	
	//methods to get the service description and the price 
	public String getServiceDescrtiption()
	{
		return serviceDescription;
	}
	
	public double getPrice()
	{
		return price;
	}
	
}



