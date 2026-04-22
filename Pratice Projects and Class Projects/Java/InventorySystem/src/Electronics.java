
public class Electronics extends Product
{
	//fields
	private int warrantyPeriod;
	private char rating;
	
	//getters
	public int getWarrantyPeriod()
	{
		return warrantyPeriod;
	}
	
	public int getRating()
	{
		return rating;
	}
	
	//setters
	public void setWarrantyPeriod(int warranty)
	{
		warrantyPeriod = warranty;
	}
	
	public void setRating(char rating)
	{
		this.rating = rating;
	}
}
