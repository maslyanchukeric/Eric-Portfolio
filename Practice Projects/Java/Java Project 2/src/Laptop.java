import javax.swing.JOptionPane;

//Class extends item class
public class Laptop extends Item
{
	//fields for the class model and type
	private String model;
	private String type;
	

	/*
	 * Parameterized Consturctor
	 * Laptop class inheriting the items class parameters
	 * Laptop title
	 * Laptop author
	 * Laptop year
	 * Laptop model
	 * Laptop type
	 */
	public Laptop(String title, String autor, int year, String model, String type)
	{
		super(title, autor, year);
		
		this.model = model;
		this.type = type;
	}
	
	//get the laptop model and type
	public String getModel()
	{
		return model;
	}
	public String getType()
	{
		return type;
	}
	
	//set the model and type
	public void setModel(String model)
	{
		this.model = model;
	}
	public void setType(String type)
	{
		this.type = type;
	}
	
	//display the laptop model and type
	public void displayLaptop()
	{
		//aslo displays the item info
		displayItem();
		
		JOptionPane.showMessageDialog(null, "\nLaptop Model: " + this.model +
											"\nLaptop Type: " + this.type);
	}

}
