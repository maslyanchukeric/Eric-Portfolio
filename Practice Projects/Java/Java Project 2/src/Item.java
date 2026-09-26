import javax.swing.JOptionPane;

//Item class created
public class Item 
{
	//Creating item fields for the class
	private String title;
	private String author;
	private int year;
	
	
	
	/*
	 * Parameterized Consturctor
	 * item title
	 * item author
	 * item year
	 */
	public Item(String title, String author, int year)
	{
		this.title = title;
		this.author = author;
		this.year = year;
	}
	
	//getting title author and year
	public String getTitle()
	{
		return title;
	}
	public String getAuthor()
	{
		return author;
	}
	public int getYear()
	{
		return  year;
	}
	
	//set the title, author, year
	public void setTitle(String title)
	{
		this.title = title;
	}
	public void setAuthor(String author)
	{
		this.author = author;
	}
	public void setYear(int year)
	{
		this.year = year;
	}
	
	//display the item title author year
	public void displayItem()
	{
		JOptionPane.showMessageDialog(null, "\nItem Title: " + this.title +
											"\nItem Author:  " + this.author + 
											"\nItem Year: " + this.year);
	}
}
