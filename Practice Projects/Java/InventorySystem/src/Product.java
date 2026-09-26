//create a base class called product 

import java.text.MessageFormat;

public class Product 
{
	private String productName;
	private int productID;
	private double price;
	private int quantity;
	private String description;
	private int minimumThreshold;
	
	//Constructor
	public Product(String productName, int productID, double price, int quantity, String descriptioin, int minimumThreshold)
	{
		this.productName = productName;
		this.productID = productID;
		this.price = price;
		this.quantity = quantity;
		this.description = description;
		this.minimumThreshold = minimumThreshold;

	}
	
	//overload constructor
	public Product(String productName, int productID, double price)
	{
		this(productName, productID, price, 0, null, 0);
	}
	
	//parameterless list constructor
	public Product()
	{
		this(null, 0, 0.0, 0, null, 0);
	}
	
	//getters-accessors
	public String getProductName()
	{
		return productName;
	}
	
	public int getProductID()
	{
		return productID;
	}
	
	public double getprice()
	{
		return price;
	}
	
	public int quantity()
	{
		return quantity;
	}
	
	public String description()
	{
		return description;
	}
	
	public int minimumThreshold()
	{
		return minimumThreshold;
	}
	//setter-mutators
	public void setProductName(String productName)
	{
		this.productName = productName;
	}
	
	public void setPoductID(int productID)
	{
		this.productID = productID;
	}
	
	public void setPrice(double price)
	{
		this.price = price;
	}
	
	public void setQuantity(int numItems)
	{
		quantity = numItems;
	}
	
	public void setDescription(String descr)
	{
		description = descr;
	}
	
	public void setMinimumThreshold(int minimum)
	{
		minimumThreshold = minimum;
	}
	
	//@override



public String toString()
	{
	
		return MessageFormat.format(" Name: {0} ID: {1} Price: {2}", this.productName, this.productID, this.price);
		//return "Name: "+this.productName  + "  ID:"+ this.productID  + "  Price: "+this.price;
	}
}
