import javax.swing.JOptionPane;

//DVD extends the item class
public class DVD extends Item 
{
	//feild for the dvd class 
	private String director;
	private int duration;
	
	/*
	 * Parameterized Consturctor
	 * Dvd class inheriting the items class parameters
	 * Dvd title
	 * dvd author
	 * dvd year
	 * dvd director
	 * dvd duration
	 */
	public DVD(String title, String autor, int year, String director, int duration)
	{
		//inherits the item class
		super(title, autor, year);
		
		this.director = director;
		this.duration = duration;
	}
	
	//get the director and duration
	public String getDirector()
	{
		return director;
	}
	public int getDuration()
	{
		return duration;
	}
	
	//set the director and duration
	public void setDirector(String director) 
	{
		this.director = director;
	}
	public void setDuration(int duration)
	{
		this.duration = duration;
	}
	
	//display the director and the duration
	public void displayDVD()
	{
		//aslo displays the item info
		displayItem();
		
		JOptionPane.showMessageDialog(null, "\nDVD Director: " + this.director +
											"\nDVD Duration mins: " + this.duration );
	}
}
