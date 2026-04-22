// Class to store name and address information
public class NameAndAddress //class name
{	
	//fields in the class
	private String name;
	private String address;
	private int zipCode;

	// Constructor
	public NameAndAddress(String name, String address, int zip) 
	{
		this.name = name;
		this.address = address;
		this.zipCode = zip;
	}

	// Method to display details
	public void display() 
	{
		System.out.println(name);
		System.out.println(address);
		System.out.println(zipCode);
	}

}

//School class using Composition (HAS-A NameAndAddress)
class School 
{
	private NameAndAddress nameAdd; // Composition
	private int enrollment;

	// Constructor initializes NameAndAddress object
	public School(String name, String address, int zip, int enrolled) 
	{
		nameAdd = new NameAndAddress(name, address, zip);
		this.enrollment = enrolled;
	}

	// Method to display School details
	public void display() 
	{
		System.out.println("School Information:");
		nameAdd.display(); // Calls display from NameAndAddress
		System.out.println("Enrollment: " + enrollment);
	}
}