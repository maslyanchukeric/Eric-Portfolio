
public class Clothing extends Product 
{
	//fields 
	private int size;
	private String color;
	private String material;
	
	//getters
	public int getSize() 
	{
		return size;
	}
	
	public String getColor()
	{
		return color;
	}
	
	public String getMaterial()
	{
		return material;
	}
	
	//setters
	public void setSize(int size)
	{
		this.size = size;
	}
	
	public void setColor(String color)
	{
		this.color = color;
	}
	
	public void setMaterial(String material)
	{
		this.material = material;
	}

	//@override
	public String toString()
	{
		return "Name: " + this.getProductName() + "  ID:" + this.getProductID() + "  Price: "+ this.getprice() + size + material;
	}
}
