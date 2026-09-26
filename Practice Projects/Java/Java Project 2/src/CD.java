import javax.swing.JOptionPane;

//Class extends item class
public class CD extends Item 
{
	//feilds for this class
	private String mediaType;
	private int cdDuration;
	private String type;
	
	/*
	 * Parameterized Consturctor
	 * CD class inheriting the items class parameters
	 * CD title
	 * CD author
	 * CD year
	 * CD model
	 * CD type
	 */
	public CD(String title, String autor, int year, String mediaType, int cdDuration)
	{
		//inherits the item class
		super(title, autor, year);
		
		this.mediaType = mediaType;
		this.cdDuration = cdDuration;
	}
	
	//getting the cd media type and duration
	public String getMediaType()
	{
		return mediaType;
	}
	public int getCdDuration()
	{
		return cdDuration;
	}
	
	//set the cd mediaType and duration
	public void setMediaType(String mediaType)
	{
		this.mediaType = mediaType;
	}
	public void setCdDuration(int cdDuration)
	{
		this.cdDuration = cdDuration;
	}
	
	//display the cd mediaType and duration
	public void displayCD()
	{
		//aslo displays the item info
		displayItem();
		
		JOptionPane.showMessageDialog(null, "\nCD MediaTyep: " + this.mediaType +
											"\nCD Duration : " + this.type + " mins ");
	}
}	


